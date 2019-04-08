using FamiHub.Models.Enum;
using System;

namespace FamiHub.Models.Core
{
    public class ExpenseNotes
    {
        public virtual Guid Id { get; set; }
        public virtual User Requestedby { get; set; }
        public virtual DateTime RequestedOn { get; set; }
        public virtual string BankAccount { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Department { get; set; }
        public virtual double Amount { get; set; }
        public virtual string Comments { get; set; }
        public virtual DateTime? ApprovalOn { get; set; }
        public virtual User ApprovalBy { get; set; }
        public virtual ApprovalStates ApprovalState { get; set; }
    }
    public class Country
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string IsoCode { get; set; }
    }
    public class Salutation
    {
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Short { get; set; }
    }

    public class TemporaryFolder
    {
        public virtual string Path { get; set; }
        public virtual Session Session { get; set; }
    }
    public class ExternalReference
    {
        public virtual string InternalReference { get; set; }
        public virtual string Reference { get; set; }
        public virtual string ExternalLinkedReference { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual DateTime LastUpdateOn { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ExternalReference ER = (ExternalReference)obj;
            if (ER == null)
                return false;

            if (InternalReference == ER.InternalReference && Reference == ER.Reference)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (InternalReference + "|" + Reference).GetHashCode();
        }
    }
}
