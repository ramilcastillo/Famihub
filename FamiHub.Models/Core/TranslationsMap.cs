using FluentNHibernate.Mapping;

namespace FamiHub.Models.Core
{
    class FormTranslationMap : ClassMap<FormTranslation>
    {
        public FormTranslationMap()
        {
            CompositeId()
                .KeyProperty(x => x.Form)
                .KeyProperty(x => x.Component)
                .KeyProperty(x => x.Language);
            Map(x => x.Translation);
            Map(x => x.Translated);
            Table("c_form_translation");
        }
    }
    class MessageTranslationMap : ClassMap<MessageTranslation>
    {
        public MessageTranslationMap()
        {
            CompositeId()
                .KeyProperty(x => x.MessageGroup)
                .KeyProperty(x => x.Message)
                .KeyProperty(x => x.Language);
            Map(x => x.Translation);
            Map(x => x.Translated);
            Table("c_message_translation");
        }
    }
}
