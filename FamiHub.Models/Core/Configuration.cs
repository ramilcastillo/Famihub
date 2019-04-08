namespace FamiHub.Models.Core
{
    public class Program
    {
        public virtual string Form { get; set; }
        public virtual string Description { get; set; }
        public virtual string Type { get; set; }
        public virtual string Code { get; set; }
        public virtual Module Package { get; set; }
    }
    public class Module
    {
        public virtual string Package { get; set; }
        public virtual string Description { get; set; }
    }
    public class Property
    {
        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
        public virtual byte[] Content { get; set; }
    }
    public class Menu
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Icon { get; set; }
    }
    public class MenuItem
    {
        public virtual int Id { get; set; }
        public virtual Program Program { get; set; }
        public virtual int Sequence { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
