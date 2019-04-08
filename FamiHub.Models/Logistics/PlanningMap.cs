using FluentNHibernate.Mapping;

namespace FamiHub.Models.Logistics
{
    class PlanningLocationMap : ClassMap<PlanningLocation>
    {
        public PlanningLocationMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.ContainerLocation);
            Table("l_planning_location");
        }
    }
    class PlanningMap : ClassMap<Planning>
    {
        public PlanningMap()
        {
            Id(x => x.Id);
            Map(x => x.PlannedOn);
            Map(x => x.PlannedOnHour);
            Map(x => x.Transporter);
            Map(x => x.Supplier);
            Map(x => x.SupplierReference);
            Map(x => x.OrderNumber);
            Map(x => x.Quantity);
            Map(x => x.Dock);
            Map(x => x.Rayon);
            Map(x => x.Comments);
            Map(x => x.TrackTraceLink);
            Map(x => x.NoAppointment);
            Map(x => x.Received);
            Map(x => x.Attachment);
            Map(x => x.AttachmentName);
            References(x => x.PlanningLocation);
            References(x => x.PlanningMadeBy);
            Map(x => x.PlanningMadeOn);
            References(x => x.PlanningModifiedBy);
            Map(x => x.PlanningModifiedOn);
            Map(x => x.Confirmed);
            Map(x => x.ContainerNumber);
            Map(x => x.DeliveryAtPort);
            Map(x => x.DeliveryMethod);
            Map(x => x.AllContainerInfoReceived);
            Map(x => x.NeedPeopleUnloading);
            Map(x => x.NeedPeopleUnloadingConfirmed);
            Table("l_planning");
        }
    }
}
