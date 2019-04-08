using FluentNHibernate.Mapping;

namespace FamiHub.Models.Core
{
    class ModuleMap : ClassMap<Module>
    {
        public ModuleMap()
        {
            Id(x => x.Package);
            Map(x => x.Description);
            Table("c_module");
        }
    }
    class ProgramMap : ClassMap<Program>
    {
        public ProgramMap()
        {
            Id(x => x.Form);
            Map(x => x.Description);
            Map(x => x.Code);
            Map(x => x.Type);
            References(x => x.Package);
            Table("c_program");
        }
    }
    class PropertyMap : ClassMap<Property>
    {
        public PropertyMap()
        {
            Id(x => x.Key);
            Map(x => x.Value);
            Map(x => x.Content);
            Table("c_property");
        }
    }
    class MenuMap : ClassMap<Menu>
    {
        public MenuMap()
        {
            Id(x => x.Id).GeneratedBy.Sequence("c_menu_sequence");
            Map(x => x.Description);
            Map(x => x.Icon);
            Table("c_menu");
        }
    }
    class MenuItemMap : ClassMap<MenuItem>
    {
        public MenuItemMap()
        {
            Id(x => x.Id).GeneratedBy.Sequence("c_menu_items_sequence");
            References(x => x.Program);
            References(x => x.Menu);
            Map(x => x.Sequence);
            Table("c_menu_items");
        }
    }
}
