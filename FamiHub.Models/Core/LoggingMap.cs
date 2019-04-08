using FluentNHibernate.Mapping;

namespace FamiHub.Models.Core
{
    class LoggingMap : ClassMap<Logging>
    {
        public LoggingMap()
        {
            Id(x => x.Id).GeneratedBy.Sequence("c_logging_sequence");
            Map(x => x.Timestamp);
            Map(x => x.Hostname);
            References(x => x.User);
            Map(x => x.Text).Length(1000);
            Map(x => x.Level);
            Table("c_logging");
        }
    }
    class ErrorMap : ClassMap<Error>
    {
        public ErrorMap()
        {
            Id(x => x.Id);
            Map(x => x.ErrorDescription);
            Map(x => x.Version);
            Map(x => x.ErrorTime);
            Map(x => x.Place);
            Map(x => x.Method);
            Map(x => x.ClassName);
            Map(x => x.LongError).Length(10000);
            Map(x => x.StackInfo).Length(10000);
            Map(x => x.Host);
            Map(x => x.OS);
            References(x => x.User);
            Table("c_errors");
        }
    }
}
