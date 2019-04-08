using FluentNHibernate.Mapping;

namespace FamiHub.Models.Core
{
    class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.IsoCode);
            Table("c_country");
        }
    }

    class SalutationMap : ClassMap<Salutation>
    {
        public SalutationMap()
        {
            Id(x => x.Id);
            Map(x => x.Title);
            Map(x => x.Short);
            Table("c_salutation");
        }
    }

    class TemporaryFolderMap : ClassMap<TemporaryFolder>
    {
        public TemporaryFolderMap()
        {
            Id(x => x.Path);
            References(x => x.Session);
            Table("c_temporary_folders");
        }
    }

    class ExpenseNotesMap : ClassMap<ExpenseNotes>
    {
        public ExpenseNotesMap()
        {
            Id(x => x.Id);
            References(x=>x.Requestedby);
            Map(x => x.RequestedOn);
            Map(x=>x.BankAccount);
            Map(x => x.Date);
            Map(x => x.Department);
            Map(x => x.Amount);
            Map(x => x.Comments);
            Map(x => x.ApprovalOn);
            References(x => x.ApprovalBy);
            Map(x => x.ApprovalState);
            Table("c_expensenotes");
        }
    }

    class ExternalReferenceMap : ClassMap<ExternalReference>
    {
        public ExternalReferenceMap()
        {
            CompositeId()
                .KeyProperty(x => x.InternalReference)
                .KeyProperty(x => x.Reference);
            Map(x => x.ExternalLinkedReference);
            Map(x => x.CreatedOn);
            Map(x => x.LastUpdateOn);
            Table("c_external_references");
        }
    }
}
