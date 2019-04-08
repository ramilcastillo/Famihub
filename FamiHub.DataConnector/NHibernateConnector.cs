using NHibernate;
using System.Collections.Generic;

namespace FamiHub.DataConnector
{
    public class NHibernateConnector
    {
        private static SessionCatalog connections = new SessionCatalog();
        private class SessionCatalog
        {
            private readonly IDictionary<string, object> _vars = new Dictionary<string, object>();
            public object this[string key]
            {
                get
                {
                    if (_vars.ContainsKey(key))
                    {
                        return _vars[key];
                    }
                    else
                    {
                        return null;
                    }
                }

                set
                {
                    _vars[key] = value;
                }

            }
        }
        private static ISessionFactory SessionFactory(string connectionString)
        {
            if (connections[connectionString] == null)
            {
                connections[connectionString] = NHibernateFunctions.NHibernateConfiguration(connectionString, false).BuildSessionFactory();
            }
            return (ISessionFactory)connections[connectionString];
        }
        public static ISession OpenSession()
        {
            return SessionFactory(Properties.Settings.Default.ConnectionString).OpenSession();
        }
        public static void UpdateDbSchema()
        {
            var session = NHibernateFunctions.NHibernateConfiguration(Properties.Settings.Default.ConnectionString, true).BuildSessionFactory().OpenSession();
            session.Close();
        }
    }
}
