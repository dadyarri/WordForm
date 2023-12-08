using System;
using System.IO;
using System.Text;
using System.Xml;
using Common.Data;

namespace Common.Serialization
{
    public class XmlSerializer
    {
        private static readonly System.Xml.Serialization.XmlSerializer Serializer = new System.Xml.Serialization.XmlSerializer(typeof(FieldsCollection));

        public static string Serialize(FieldsCollection source)
        {
            var stringBuilder = new StringBuilder();

            using (var xmlWriter = XmlWriter.Create(stringBuilder, new XmlWriterSettings
                   {
                       Encoding = Encoding.UTF8
                   }))
            {
                Serializer.Serialize(xmlWriter, source);
            }

            return stringBuilder.ToString();
        }

        public static bool TryDeserialize(string source, out FieldsCollection data)
        {
            using (TextReader reader = new StringReader(source))
            {
                try
                {
                    var o = Serializer.Deserialize(reader);
                    data = (FieldsCollection) o;
                    return true;
                }
                catch (Exception)
                {
                    data = null;
                    return false;
                }
            }
        }
    }
}