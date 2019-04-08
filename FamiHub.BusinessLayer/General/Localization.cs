using FamiHub.Models.Core;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace FamiHub.BusinessLayer.General
{
    public class LocalizationRequests
    {
        public class ComponentTranslationRequest
        {
            public string Form;
            public string Component;
            public string Language;
            public string CurrentLabel;
        }
        public class MessageTranslationRequest
        {
            public string Message;
            public string Language;
            public string Group;
        }
        public class FormTranslationRequest
        {
            public string Form;
            public string Language;
        }
    }
    public static class Localization
    {
        public static FormTranslation TranslateCpt(string form, string cpt, string language, string currentLbl = "")
        {
            Logging.Log("Translate component '" + cpt + "' for form " + form + ", language=" + language, Logging.LogLevel.Debug);

            language = language.ToLower();

            DefineLanguage(language);

            var session = DataConnector.NHibernateConnector.OpenSession();
            FormTranslation ft = session.CreateCriteria(typeof(FormTranslation))
                                    .Add(Expression.Eq("Language", language))
                                    .Add(Expression.Eq("Form", form))
                                    .Add(Expression.Eq("Component", cpt))
                                    .UniqueResult<FormTranslation>();

            if (!(string.IsNullOrEmpty(ft?.Translation)))
            {
                Logging.Log("Translation found: '" + ft.Translation + "'", Logging.LogLevel.Debug);
                return ft;
            }
            else
            {
                Logging.Log("Translation not found, looking for English translation", Logging.LogLevel.Debug);
                FormTranslation fte = session.CreateCriteria(typeof(FormTranslation))
                                        .Add(Expression.Eq("Language", "en"))
                                        .Add(Expression.Eq("Form", form))
                                        .Add(Expression.Eq("Component", cpt))
                .UniqueResult<FormTranslation>();
                if (!(string.IsNullOrEmpty(fte?.Translation)))
                {
                    Logging.Log("Translation found: '" + fte.Translation + "'", Logging.LogLevel.Debug);
                    return fte;
                }
                else
                {
                    Logging.Log("Translation not found, creating new translation record", Logging.LogLevel.Debug);
                    ft = new FormTranslation();
                    ft.Form = form;
                    ft.Component = cpt;
                    ft.Language = "en";
                    ft.Translation = currentLbl;
                    ft.Translated = false;
                    Crud.Add(ft);
                    Logging.Log("Translation record added", Logging.LogLevel.Debug);
                    return ft;
                }
            }
        }
        public static IList<FormTranslation> GetFormTranslationsByForm(string form, string language)
        {
            Logging.Log("Loading form translations for form " + form + ", language=" + language, Logging.LogLevel.Debug);
            var session = DataConnector.NHibernateConnector.OpenSession();
            IList<FormTranslation> ft = session.CreateCriteria(typeof(FormTranslation))
                                                .Add(Expression.Eq("Language", language))
                                                .Add(Expression.InsensitiveLike("Form", form))
                                                .List<FormTranslation>();
            Logging.Log("Form translations loaded for form " + form + ", language=" + language, Logging.LogLevel.Info);
            return ft;
        }
        public static MessageTranslation Translate(string message, string language, string group = "*")
        {
            Logging.Log("Translate message '" + message + "' for messagegroup " + group + ", language=" + language, Logging.LogLevel.Debug);

            group = group.ToUpper();
            language = language.ToLower();

            DefineLanguage(language);

            var session = DataConnector.NHibernateConnector.OpenSession();
            MessageTranslation ft = session.CreateCriteria(typeof(MessageTranslation))
                .Add(Expression.Eq("Language", language))
                .Add(Expression.Eq("MessageGroup", group))
                .Add(Expression.Eq("Message", message))
                .UniqueResult<MessageTranslation>();

            if (!(string.IsNullOrEmpty(ft?.Translation)))
            {
                Logging.Log("Translation found: '" + ft.Translation + "'", Logging.LogLevel.Debug);
                return ft;
            }
            else
            {
                Logging.Log("Translation not found, looking for English translation", Logging.LogLevel.Debug);
                MessageTranslation fte = session.CreateCriteria(typeof(MessageTranslation))
                .Add(Expression.Eq("Language", "en"))
                .Add(Expression.Eq("MessageGroup", group))
                .Add(Expression.Eq("Message", message))
                .UniqueResult<MessageTranslation>();
                if (!(string.IsNullOrEmpty(fte?.Translation)))
                {
                    Logging.Log("Translation found: '" + fte.Translation + "'", Logging.LogLevel.Debug);
                    return fte;
                }
                else
                {
                    Logging.Log("Translation not found, creating new translation record", Logging.LogLevel.Debug);
                    ft = new MessageTranslation();
                    ft.MessageGroup = group;
                    ft.Message = message;
                    ft.Language = "en";
                    ft.Translation = message;
                    ft.Translated = false;
                    Crud.Add(ft);
                    Logging.Log("Translation record added", Logging.LogLevel.Debug);
                    return ft;
                }
            }
        }
        public static void DefineLanguage(string language)
        {
            var session = DataConnector.NHibernateConnector.OpenSession();

            Logging.Log("Checking if language '" + language + "' is defined in MessageTranslation", Logging.LogLevel.Debug);

            MessageTranslation trl = session.CreateCriteria(typeof(MessageTranslation))
                .Add(Expression.Eq("MessageGroup", "*"))
                .Add(Expression.Eq("Message", "_name"))
                .Add(Expression.Eq("Language", language))
                .UniqueResult<MessageTranslation>();
            if (trl == null)
            {
                Logging.Log("Language '" + language + "' is not defined, creating record in MessageTranslation", Logging.LogLevel.Debug);
                trl = new MessageTranslation();
                trl.MessageGroup = "*";
                trl.Message = "_name";
                trl.Language = language;
                trl.Translation = language;
                Crud.Add(trl);
                Logging.Log("Record for language '" + language + "' is created in MessageTranslation", Logging.LogLevel.Debug);
            }
        }
        public static IList<Tuple<string, string>> GetLanguages()
        {
            Logging.Log("Loading all available languages", Logging.LogLevel.Debug);
            IList<Tuple<string, string>> result = new List<Tuple<string, string>>();
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                IList<MessageTranslation> langs = session.CreateCriteria(typeof(MessageTranslation))
                    .Add(Expression.Eq("MessageGroup", "*"))
                    .Add(Expression.Eq("Message", "_name"))
                    .List<MessageTranslation>();

                foreach (MessageTranslation lang in langs)
                {
                    Tuple<string, string> langTuple = new Tuple<string, string>(lang.Language, lang.Translation);
                    result.Add(langTuple);
                }
            }
            return result;
        }
        public class TranslationWrapper
        {
            public string Form { get; set; }
            public string Component { get; set; }
            public string English { get; set; }
            public string NewLang { get; set; }
            public string Translation { get; set; }
        }
        public static void SetFormTranslation(TranslationWrapper translation)
        {
            DefineLanguage(translation.NewLang);
            FormTranslation trl = new FormTranslation();
            trl.Component = translation.Component;
            trl.Form = translation.Form;
            trl.Language = translation.NewLang;
            trl.Translation = translation.Translation;
            trl.Translated = true;
            Crud.Put(trl);
        }
        public static IList<TranslationWrapper> GetFormTranslationsByForm(string form, string language, bool onlyNotTranslated)
        {
            IList<TranslationWrapper> resultList = new List<TranslationWrapper>();
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                IList<FormTranslation> fte = session.CreateCriteria(typeof(FormTranslation))
                                                    .Add(Expression.Eq("Language", "en"))
                                                    .Add(Expression.InsensitiveLike("Form", "%" + form + "%"))
                                                    .List<FormTranslation>();

                foreach (FormTranslation tr in fte)
                {
                    FormTranslation ftt = session.CreateCriteria(typeof(FormTranslation))
                                                    .Add(Expression.Eq("Language", language))
                                                    .Add(Expression.Eq("Form", tr.Form))
                                                    .Add(Expression.Eq("Component", tr.Component))
                                                    .UniqueResult<FormTranslation>();
                    if ((onlyNotTranslated && string.IsNullOrEmpty(ftt?.Translation)) || !onlyNotTranslated)
                    {
                        TranslationWrapper tw = new TranslationWrapper();
                        tw.Form = tr.Form;
                        tw.Component = tr.Component;
                        tw.English = tr.Translation;
                        tw.NewLang = language;
                        tw.Translation = "";
                        if (!(string.IsNullOrEmpty(ftt?.Translation)))
                            tw.Translation = ftt.Translation;
                        resultList.Add(tw);
                    }
                }
            }
            return resultList;
        }
        public static void SetMessageTranslation(TranslationWrapper translation)
        {
            DefineLanguage(translation.NewLang);
            MessageTranslation trl = new MessageTranslation();
            trl.Message = translation.Component;
            trl.MessageGroup = translation.Form;
            trl.Language = translation.NewLang;
            trl.Translation = translation.Translation;
            trl.Translated = true;
            Crud.Put(trl);
        }
        public static IList<TranslationWrapper> GetMessageTranslationsByForm(string messageGroup, string language, bool onlyNotTranslated)
        {
            IList<TranslationWrapper> resultList = new List<TranslationWrapper>();
            using (var session = DataConnector.NHibernateConnector.OpenSession())
            {
                IList<MessageTranslation> fte = session.CreateCriteria(typeof(MessageTranslation))
                                                    .Add(Expression.Eq("Language", "en"))
                                                    .Add(Expression.InsensitiveLike("MessageGroup", "%" + messageGroup + "%"))
                                                    .List<MessageTranslation>();

                foreach (MessageTranslation tr in fte)
                {
                    MessageTranslation ftt = session.CreateCriteria(typeof(MessageTranslation))
                                                    .Add(Expression.Eq("Language", language))
                                                    .Add(Expression.Eq("MessageGroup", tr.MessageGroup))
                                                    .Add(Expression.Eq("Message", tr.Message))
                                                    .UniqueResult<MessageTranslation>();
                    if ((onlyNotTranslated && string.IsNullOrEmpty(ftt?.Translation)) || !onlyNotTranslated)
                    {
                        TranslationWrapper tw = new TranslationWrapper();
                        tw.Form = tr.MessageGroup;
                        tw.Component = tr.Message;
                        tw.English = tr.Translation;
                        tw.NewLang = language;
                        tw.Translation = "";
                        if (!(string.IsNullOrEmpty(ftt?.Translation)))
                            tw.Translation = ftt.Translation;
                        resultList.Add(tw);
                    }
                }
            }
            return resultList;
        }
    }
}
