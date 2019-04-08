using System;

namespace FamiHub.Models.Logistics
{
    public class PlanningLocation
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool ContainerLocation { get; set; }
    }
    public class Planning
    {
        public Planning()
        {
            PlannedOn = DateTime.Now;
            DeliveryAtPort = DateTime.Now;
        }
        public virtual Guid Id { get; set; }
        public virtual DateTime PlannedOn { get; set; }
        public virtual string PlannedOnHour { get; set; }
        public virtual string Transporter { get; set; }
        public virtual string Supplier { get; set; }
        public virtual string SupplierReference { get; set; }
        public virtual string OrderNumber { get; set; }
        public virtual string Quantity { get; set; }
        public virtual string Dock { get; set; }
        public virtual string Rayon { get; set; }
        public virtual string Comments { get; set; }
        public virtual string TrackTraceLink { get; set; }
        public virtual bool NoAppointment { get; set; }
        public virtual bool Received { get; set; }
        public virtual byte[] Attachment { get; set; }
        public virtual string AttachmentName { get; set; }
        public virtual PlanningLocation PlanningLocation { get; set; }
        public virtual Core.User PlanningMadeBy { get; set; }
        public virtual DateTime PlanningMadeOn { get; set; }
        public virtual Core.User PlanningModifiedBy { get; set; }
        public virtual DateTime PlanningModifiedOn { get; set; }
        public virtual bool Confirmed { get; set; }
        public virtual string ContainerNumber { get; set; }
        public virtual DateTime? DeliveryAtPort { get; set; }
        public virtual string DeliveryMethod { get; set; }
        public virtual bool AllContainerInfoReceived { get; set; }
        public virtual bool NeedPeopleUnloading { get; set; }
        public virtual bool NeedPeopleUnloadingConfirmed { get; set; }
    }
}
