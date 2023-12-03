using System.Collections.Generic;

namespace Common.Data
{
    public class FieldsCollection
    {
        public List<FieldInfo> FormFields { get; set; }

        public FieldsCollection()
        {
            FormFields = new List<FieldInfo>();
        }
    }
}