#region License
// *******************************************************
// Copyright (c) 2018 Famiflora SA
// 
// This file is part of FamiHub.
// FamiHub can not be copied and/or distributed without the express
// permission of Famiflora SA.
// *******************************************************
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.Common
{
    internal class Xml
    {
        public static void objectToXml<T>(T o, string file)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (var writer = System.Xml.XmlWriter.Create(file))
            {
                serializer.Serialize(writer, o);
            }
        }
        public static object xmlToObject<T>(string file)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (System.IO.StreamReader reader = new System.IO.StreamReader(file))
            {
                return serializer.Deserialize(reader);
            }
        }
    }
}
