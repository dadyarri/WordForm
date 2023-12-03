using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office = Microsoft.Office.Core;

namespace WordForm.Xml
{
    internal class XmlUtils
    {
        public void WriteCustomXmlPart(Office.CustomXMLParts customParts, string xmlPart)
        {
            customParts.Add(xmlPart);
        }
    }
}
