using System;

namespace FamiHub.Models.Core
{
    public class Logging
    {
        public virtual long Id { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual User User { get; set; }
        public virtual string Hostname { get; set; }
        public virtual string Text { get; set; }
        public virtual int Level { get; set; }
    }
    public class Error
    {
        public virtual int Id { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime ErrorTime { get; set; }
        public virtual string ErrorDescription { get; set; }
        public virtual string Version { get; set; }
        public virtual string Method { get; set; }
        public virtual string ClassName { get; set; }
        public virtual string Place { get; set; }
        public virtual string LongError { get; set; }
        public virtual string StackInfo { get; set; }
        public virtual string Host { get; set; }
        public virtual string OS { get; set; }
    }
}
