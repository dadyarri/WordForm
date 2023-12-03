using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Data;
using Common.Serialization;
using Office = Microsoft.Office.Core;

namespace WordForm.Xml
{
    internal class XmlUtils
    {
        public static void WriteCustomXmlPart(Office.CustomXMLParts customParts, FieldsCollection xmlPart)
        {
            var stringData = XmlSerializer<FieldsCollection>.Serialize(xmlPart);
            customParts.Add(stringData);
        }
    }
}
