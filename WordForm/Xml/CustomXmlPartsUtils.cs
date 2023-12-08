using Common.Data;
using Common.Serialization;
using Office = Microsoft.Office.Core;

namespace WordForm.Xml
{
    internal class CustomXmlPartsUtils
    {
        public static string Add(Office.CustomXMLParts customParts, FieldsCollection xmlPart)
        {
            var stringData = XmlSerializer.Serialize(xmlPart);
            var part = customParts.Add(stringData);
            return part.Id;
        }

        public static Office.CustomXMLPart Get(Office.CustomXMLParts customParts, string id)
        {
            return customParts[id];
        }

        public static Office.CustomXMLPart Update(Office.CustomXMLPart customPart, string newXml)
        {
            customPart.LoadXML(newXml);
            return customPart;
        }
    }
}
