using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;

namespace FamiHub
{
    public class Crud
    {
        public static IList<Type> GetListQuery<Type>(string queryString)
        {
            if (!String.IsNullOrEmpty(queryString))
            {
                if (queryString.Contains("="))
                {
                    using (var session = DataConnector.NHibernateConnector.OpenSession())
                    {
                        var query = session.CreateCriteria(typeof(Type));

                        string[] filters = queryString.Split('&');
                        foreach (string filter in filters)
                        {
                            string field = filter.Split('=')[0].Split('[')[0];
                            System.Type fieldType = typeof(string);

                            FieldInfo[] fieldInfos = typeof(Type).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                            foreach (var fieldInfo in fieldInfos)
                            {
                                if (fieldInfo.Name.Split('>')[0].Replace("<", "") == field)
                                {
                                    fieldType = fieldInfo.FieldType;
                                }
                            }

                            string searchQueryValue = filter.Split('=')[1];

                            if (searchQueryValue == "null") searchQueryValue = null;
                            string filterOperator = filter.Split('[')[1].Split(']')[0].ToLower();
                            dynamic filterValue;

                            if (fieldType != typeof(String))
                            {
                                var converter = TypeDescriptor.GetConverter(fieldType);
                                filterValue = converter.ConvertFrom(searchQueryValue);
                            }
                            else
                            {
                                filterValue = Convert.ChangeType(searchQueryValue, fieldType);
                            }

                            if (filterOperator == "eq") query.Add(Restrictions.Eq(field, filterValue));
                            if (filterOperator == "eqproperty") query.Add(Restrictions.EqProperty(field, filterValue.ToString()));
                            if (filterOperator == "ge") query.Add(Restrictions.Ge(field, filterValue));
                            if (filterOperator == "geproperty") query.Add(Restrictions.GeProperty(field, filterValue.ToString()));
                            if (filterOperator == "gt") query.Add(Restrictions.Gt(field, filterValue));
                            if (filterOperator == "gtproperty") query.Add(Restrictions.GtProperty(field, filterValue.ToString()));
                            if (filterOperator == "insensitivelike") query.Add(Restrictions.InsensitiveLike(field, filterValue));
                            if (filterOperator == "le") query.Add(Restrictions.Le(field, filterValue));
                            if (filterOperator == "leproperty") query.Add(Restrictions.LeProperty(field, filterValue.ToString()));
                            if (filterOperator == "lt") query.Add(Restrictions.Lt(field, filterValue));
                            if (filterOperator == "ltproperty") query.Add(Restrictions.LtProperty(field, filterValue.ToString()));
                            if (filterOperator == "noteq") query.Add(Restrictions.Not(Restrictions.Eq(field, filterValue)));
                            if (filterOperator == "noteqproperty") query.Add(Restrictions.NotEqProperty(field, filterValue.ToString()));
                        }
                        IList<Type> result = query.List<Type>();
                        return result;
                    }
                }
                else
                {
                    return GetAll<Type>();
                }
            }
            else
            {
                return GetAll<Type>();
            }
        }
        public static IList<Type> GetList<Type, FieldType>(string field, FieldType value, string expresssionOperator = "=")
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var opt = session.CreateCriteria(typeof(Type));
            if (expresssionOperator == "=")
            {
                opt.Add(Expression.Eq(field, value));
            }
            else if (expresssionOperator == "like")
            {
                opt.Add(Expression.Like(field, value));
            }
            IList<Type> result = opt.List<Type>();
            session.Close();
            return result;
        }
        public static IList<Type> Query<Type>(string query)
        {
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                return session.CreateQuery(query).List<Type>();
            }
        }
        public static void Put<Type>(Type data)
        {
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(data);
                    transaction.Commit();
                }
            }
        }

        public static void Add<Type>(Type data)
        {
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(data);
                    transaction.Commit();
                }
            }
        }

        public static void Update<Type>(Type data)
        {
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(data);
                    transaction.Commit();
                }
            }
        }

        public static void Delete<Type>(Type data)
        {
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(data);
                    transaction.Commit();
                }
            }
        }

        public static Type GetById<Type, IdType>(IdType id)
        {

            var session = DataConnector.NHibernateConnector.OpenSession();
            Type result = session.Get<Type>(id);
            session.Close();

            return result;
        }

        public static IList<Type> GetAll<Type>()
        {

            var session = DataConnector.NHibernateConnector.OpenSession();
            var opt = session.CreateCriteria(typeof(Type));
            IList<Type> result = opt.List<Type>();
            session.Close();

            return result;
        }

        public static ISession Request()
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            return session;
        }

        public static ITransaction Transaction(ISession session)
        {
            var transaction = session.BeginTransaction();
            return transaction;
        }
    }
}