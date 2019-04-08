using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.Models.Core
{
    public class FormTranslation
    {
        public virtual string Form { get; set; }
        public virtual string Component { get; set; }
        public virtual string Language { get; set; }
        public virtual string Translation { get; set; }
        public virtual bool Translated { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            FormTranslation FT = (FormTranslation)obj;
            if (FT == null)
                return false;

            if (Form == FT.Form && Component == FT.Component && Language == FT.Language)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (Form + "|" + Component + "|" + Language).GetHashCode();
        }

    }
    public class MessageTranslation
    {
        public virtual string MessageGroup { get; set; }
        public virtual string Message { get; set; }
        public virtual string Language { get; set; }
        public virtual string Translation { get; set; }
        public virtual bool Translated { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MessageTranslation MT = (MessageTranslation)obj;
            if (MT == null)
                return false;

            if (MessageGroup == MT.MessageGroup && Message == MT.Message && Language == MT.Language)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (MessageGroup + "|" + Message + "|" + Language).GetHashCode();
        }
    }
}
