#region License
// *******************************************************
// Copyright (c) 2018 Famiflora SA
// 
// This file is part of FamiHub.
// FamiHub can not be copied and/or distributed without the express
// permission of Famiflora SA.
// *******************************************************
#endregion
using FamiHub.Models.Core;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Net;

namespace FamiHub.Common
{
    public static class Localization
    {
        private static bool webApi = (1 == Convert.ToInt16(Crud.GetById<Models.Core.Property, string>("Translation:WebApi")?.Value ?? "0"));
        private static T PostWebApiClient<T>(string function, object translationObject)
        {
            string userName = Crud.GetById<Models.Core.Property, string>("Translation:ApiUser")?.Value ?? "admin";
            string password = Crud.GetById<Models.Core.Property, string>("Translation:ApiPassword")?.Value ?? "admin";
            string host = Crud.GetById<Models.Core.Property, string>("Translation:ApiHost")?.Value ?? "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host + "/api/" + function);
            request.Method = "GET";
            String result = String.Empty;
            request.Headers[HttpRequestHeader.ContentType] = "application/json";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(userName + ":" + password));

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(translationObject);
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] content = encoding.GetBytes(json);
            System.IO.Stream contentStream = request.GetRequestStream();
            contentStream.Write(content, 0, content.Length);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                System.IO.Stream dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }

            dynamic objResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(T));
            return objResult;
        }
        private static T GetWebApiClient<T>(string function)
        {
            string userName = Crud.GetById<Models.Core.Property, string>("Translation:ApiUser")?.Value ?? "admin";
            string password = Crud.GetById<Models.Core.Property, string>("Translation:ApiPassword")?.Value ?? "admin";
            string host = Crud.GetById<Models.Core.Property, string>("Translation:ApiHost")?.Value ?? "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host + "/api/" + function);
            request.Method = "GET";
            String result = String.Empty;
            request.Headers[HttpRequestHeader.ContentType] = "application/json";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(userName + ":" + password));

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                System.IO.Stream dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            
            dynamic objResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(T));
            return objResult;
        }

        internal static string TranslateCpt(string form, string cpt, string language = "", string currentLbl = "")
        {
            if (string.IsNullOrEmpty(language)) language = Session.CurrentUser?.Language ?? "en";
            if (webApi)
            {
                var req = new BusinessLayer.General.LocalizationRequests.ComponentTranslationRequest
                {
                    Form = form,
                    Component = cpt,
                    Language = language,
                    CurrentLabel = currentLbl
                };

                return PostWebApiClient<FormTranslation>("CptTranslate", req).Translation;
            }
            else
            {
                return BusinessLayer.General.Localization.TranslateCpt(form, cpt, language, currentLbl).Translation;
            }
        }
        internal static IList<FormTranslation> GetFormTranslationsByForm(string form, string language)
        {
            if (string.IsNullOrEmpty(language)) language = Session.CurrentUser?.Language ?? "en";
            if (webApi)
            {
                var req = new BusinessLayer.General.LocalizationRequests.FormTranslationRequest
                {
                    Form = form,
                    Language = language
                };

                return PostWebApiClient<IList<FormTranslation>>("FrmTranslate", req);
            }
            else
            {
                return BusinessLayer.General.Localization.GetFormTranslationsByForm(form, language);
            }
        }
        internal static string Translate(string message, string group = "*", string language = "")
        {
            if (string.IsNullOrEmpty(language)) language = Session.CurrentUser?.Language ?? "en";
            if (webApi)
            {
                var req = new BusinessLayer.General.LocalizationRequests.MessageTranslationRequest
                {
                    Message = message,
                    Group = group,
                    Language = language
                };

                return PostWebApiClient<FormTranslation>("MsgTranslate", req).Translation;
            }
            else
            {
                return BusinessLayer.General.Localization.Translate(message, group, language).Translation;
            }
        }
        internal static void DefineLanguage(string language)
        {
            BusinessLayer.General.Localization.DefineLanguage(language);
        }
        internal static IList<Tuple<string, string>> GetLanguages()
        {
            if (webApi)
            {
                return GetWebApiClient<IList<Tuple<string, string>>>("Languages");
            }
            else
            {
                return BusinessLayer.General.Localization.GetLanguages();
            }
        }
        internal static void SetFormTranslation(BusinessLayer.General.Localization.TranslationWrapper translation)
        {
            BusinessLayer.General.Localization.SetFormTranslation(translation);
        }
        internal static IList<BusinessLayer.General.Localization.TranslationWrapper> GetFormTranslationsByForm(string form, string language, bool onlyNotTranslated)
        {
            return BusinessLayer.General.Localization.GetFormTranslationsByForm(form, language, onlyNotTranslated);
        }
        internal static void SetMessageTranslation(BusinessLayer.General.Localization.TranslationWrapper translation)
        {
            BusinessLayer.General.Localization.SetMessageTranslation(translation);
        }
        internal static IList<BusinessLayer.General.Localization.TranslationWrapper> GetMessageTranslationsByForm(string messageGroup, string language, bool onlyNotTranslated)
        {
            return BusinessLayer.General.Localization.GetMessageTranslationsByForm(messageGroup, language, onlyNotTranslated);
        }
    }
}
