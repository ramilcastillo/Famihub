using System;

namespace FamiHub.Models.Core
{
    public class Session
    {
        public virtual Guid Id { get; set; }
        public virtual User User { get; set; }
        public virtual string HostName { get; set; }
        public virtual DateTime SessionStart { get; set; }
        public virtual DateTime SessionEnd { get; set; }
    }
    public class UserGroup
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool ApiUser { get; set; }

    }

    public class UserGroupMenu
    {
        public virtual int Id { get; set; }
        public virtual UserGroup UserGroup { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual int Sequence
        {
            get; set;
        }
    }

    public class User
    {
        public User()
        {
            BecosoftUser = false;
            ApiUser = false;
        }
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual UserGroup UserGroup { get; set; }
        public virtual bool Active { get; set; }
        public virtual string Language { get; set; }
        public virtual string MailAddress { get; set; }
        public virtual bool BecosoftUser { get; set; }
        public virtual bool ApiUser { get; set; }
        public virtual ApproverType ExpenseNotesApprovalFlow { get; set; }
    }

    public class OnBehalfOfRights
    {
        public virtual Guid Id { get; set; }
        public virtual User User { get; set; }
        public virtual User OnBehalfOf { get; set; }
    }

    public class Approver
    {
        public virtual int Id { get; set; }
        public virtual string ApproverName { get; set; }
        public virtual int Level { get; set; }
        public virtual ApproverType ApproverType { get; set; }
    }

    public class ApproverType
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
    }
}
