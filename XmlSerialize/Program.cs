using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialize
{
    public class Program
    {
        public static void Main(string[] args)
        {

            XmlHelper xmlH = new XmlHelper();
            xmlH.Run();

        }

        public class XmlHelper
        {
            public XmlHelper()
            {
            }

            public void Run()
            {
                var xml = File.ReadAllText(@"S:\Source\Repos\StackOverflow\StackQuestionEvents\XmlSerialize\XMLFile1.xml");
                var Questions = Deserialize<List<question>>(xml);
                var dict = Questions.Select(q => new { q.name, q.TypeQuestion }).Where(x => x.TypeQuestion == "eazy").ToDictionary(k => k.name);
            }


            public T Deserialize<T>(string xmlString)
            {
                StringReader reader = new StringReader(xmlString);
                XmlSerializer thisDeserializer = new XmlSerializer(typeof(T));
                T ret = (T)thisDeserializer.Deserialize(reader);
                reader.Close();
                return ret;
            }
        }

        [Serializable]
        public class question
        {
            public question()
            {

            }

            public string name { get; set; }
            public string answers { get; set; }
            public string rightIndex { get; set; }
            public string TypeQuestion { get; set; }
        }

    }
}
