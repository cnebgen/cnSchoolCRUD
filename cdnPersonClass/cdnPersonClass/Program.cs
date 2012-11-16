using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace cdnPersonClass
{
    class Program
    {
        public static School school1 = new School();

        [STAThread]
        static void Main(string[] args)
        {
            if (File.Exists(@"C:\EVPlayer\test.xml"))
            {
                DeserializeTheData();
                using (SchoolEditForm mainForm = new SchoolEditForm())
                {
                    mainForm.ShowDialog();
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(@"C:\EVPlayer\");
                System.IO.FileStream fileWrite = System.IO.File.Create(@"C:\EVPlayer\test.xml");
                fileWrite.Close();
                using (SchoolEditForm mainForm = new SchoolEditForm())
                {
                    mainForm.ShowDialog();
                }
            }
            SerializeTheData();
        }

        public static void SerializeTheData()
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(School));
            TextWriter WriteFileStream = new StreamWriter(@"C:\EVPlayer\test.xml");
            SerializerObj.Serialize(WriteFileStream, school1);
            WriteFileStream.Close();
        }

        static void DeserializeTheData()
        {
            XmlSerializer DeserializerObj = new XmlSerializer(typeof(School));
            Stream reader = new FileStream(@"C:\EVPlayer\test.xml", FileMode.Open);
            school1 = (School)DeserializerObj.Deserialize(reader);
            reader.Close();
        }

    }
}
