using FluentNHibernate.Mapping;

namespace FamiHub.Models.Core
{
    class SessionMap : ClassMap<Session>
    {
        public SessionMap()
        {
            Id(x => x.Id);
            Map(x => x.HostName);
            References(x => x.User);
            Map(x => x.SessionStart);
            Map(x => x.SessionEnd);
            Table("c_user_session");
        }
    }
    class UserGroupMap : ClassMap<UserGroup>
    {
        public UserGroupMap()
        {
            Id(x => x.Id).GeneratedBy.Sequence("c_usergroup_sequence");
            Map(x => x.Name);
            Map(x => x.ApiUser);
            Table("c_usergroup");
        }
    }

    class UserGroupMenuMap : ClassMap<UserGroupMenu>
    {
        public UserGroupMenuMap()
        {
            Id(x => x.Id).GeneratedBy.Sequence("c_usergroup_menu_sequence");
            References(x => x.UserGroup);
            References(x => x.Menu);
            Map(x => x.Sequence);
            Table("c_usergroup_menu");
        }
    }

    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).GeneratedBy.Sequence("c_user_sequence");
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.UserName);
            Map(x => x.Password);
            References(x => x.UserGroup);
            Map(x => x.Active);
            Map(x => x.Language);
            Map(x => x.MailAddress);
            Map(x => x.BecosoftUser);
            Map(x => x.ApiUser);
            Table("c_user");
        }
    }

    class OnBehalfOfRightsMap : ClassMap<OnBehalfOfRights>
    {
        public OnBehalfOfRightsMap()
        {
            Id(x => x.Id);
            References(x => x.User);
            References(x => x.OnBehalfOf);
            Table("c_user_onbehalfof");
        }
    }

    class ApproverTypeMap : ClassMap<ApproverType>
    {
        public ApproverTypeMap()
        {
            Id(x => x.Id).GeneratedBy.Sequence("c_approvertype_sequence");
            Map(x => x.Description);
            Table("c_approvertype");
        }
    }

    class ApproverMap : ClassMap<Approver>
    {
        public ApproverMap()
        {
            Id(x => x.Id).GeneratedBy.Sequence("c_approver_sequence");
            Map(x => x.ApproverName);
            References(x => x.ApproverType);
            Map(x => x.Level);
            Table("c_approver");
        }
    }


}
