using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.BusinessLayer.General
{
    public static class Security
    {
        public static bool ApiAccess(string userName, string password)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var user = session.CreateCriteria(typeof(Models.Core.User))
                                            .Add(Expression.Eq("UserName", userName))
                                            .Add(Expression.Eq("Active", true))
                                            .UniqueResult<Models.Core.User>();
            if (user?.Password == Common.Encryption.Encrypt.EncryptText(password))
            {
                if (user.ApiUser)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool BecosoftUser(Models.Core.User userObject, string password)
        {
            BECO_Pro_FAM_CCLink.Users user = new BECO_Pro_FAM_CCLink.Users();
            Tuple<string, string> userFullName = null;
            bool result = user.Authenticate(userObject.UserName, password, ref userFullName);

            userObject.FirstName = userFullName.Item1;
            userObject.LastName = userFullName.Item2;
            Crud.Put(userObject);

            return result;
        }
    }
}
