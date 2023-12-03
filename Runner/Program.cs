using System;
using Common.Data;
using Common.Serialization;

namespace Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var info = new FieldInfo
            {
                Id = "some-id",
                ReplaceTag = "<fio>",
                VisibleName = "ФИО"
            };

            var root = new FieldsCollection();
            
            for (var i = 0; i < 10; i++)
            {
                root.FormFields.Add(info);
            }

            Console.WriteLine(XmlSerializer<FieldsCollection>.Serialize(root));
            Console.ReadKey();
        }
    }
}
