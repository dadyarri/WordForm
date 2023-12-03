using System.Text;
using System.Xml;

namespace Common.Serialization
{
    public class XmlSerializer<T>
    {
        private static readonly System.Xml.Serialization.XmlSerializer Serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

        public static string Serialize(T source)
        {
            var stringBuilder = new StringBuilder();

            using (var xmlWriter = XmlWriter.Create(stringBuilder, new XmlWriterSettings
                   {
                       Encoding = Encoding.UTF8,
                       Indent = true,
                       IndentChars = "  "
                   }))
            {
                Serializer.Serialize(xmlWriter, source);
            }

            return stringBuilder.ToString();
        }
    }
}