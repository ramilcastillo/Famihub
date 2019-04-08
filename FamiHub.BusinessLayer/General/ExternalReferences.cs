using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.BusinessLayer.General
{
    public static class ExternalReferences
    {
        public static void PutReference(string referenceType, object internalReference, object externalReference)
        {
            Models.Core.ExternalReference extReference = new Models.Core.ExternalReference();
            extReference.Reference = referenceType;
            extReference.InternalReference = internalReference.ToString();
            extReference.ExternalLinkedReference = externalReference.ToString();
            extReference.LastUpdateOn = DateTime.Now;

            Crud.Put(extReference);
        }

        public static string GetReference(string referenceType, object internalReference)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();
            var reference = session.CreateCriteria(typeof(Models.Core.ExternalReference))
                                 .Add(Expression.Eq("Reference", referenceType))
                                 .Add(Expression.Eq("InternalReference", internalReference.ToString()))
                                .UniqueResult<Models.Core.ExternalReference>();

            return reference.ExternalLinkedReference;
        }
    }
}
