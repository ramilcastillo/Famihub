using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Diagnostics;

namespace FamiHub.DataConnector
{
    public static class NHibernateFunctions
    {
        internal class SqlStatementInterceptor : EmptyInterceptor
        {
            public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql)
            {
                Trace.WriteLine(sql.ToString());
                return sql;
            }
        }
        internal static FluentConfiguration NHibernateConfiguration(string connectionString, bool updateDatabase = false)
        {
            var config = Fluently.Configure();
            var pgsql = PostgreSQLConfiguration.Standard;

            pgsql.Dialect<NHibernate.Dialect.PostgreSQL83Dialect>();
            pgsql.ConnectionString(connectionString);

            config.Database(pgsql);
            config.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Models.Core.UserGroup>().Conventions.Add(DefaultLazy.Never()));
            config.ExposeConfiguration(cfg => cfg.SetInterceptor(new SqlStatementInterceptor()));

            if (updateDatabase) config.ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true));

            return config;
        }
    }
}
