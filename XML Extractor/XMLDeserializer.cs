using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace XML_Extractor
{
    public class XMLDeserializer<T> where T : class
    {
        public T ExtractFromXML(string filePathXML)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            T extractedDetails;

            using (StreamReader streamReader = new StreamReader(filePathXML))
            {
                extractedDetails = (T)xmlSerializer.Deserialize(streamReader);
            }
            return extractedDetails;
        }

        public void ToJSON(T extractedDetails, string filePathJson)
        {
            StreamWriter scriptWriter = new StreamWriter(filePathJson);
            string jsonSerializedText = JsonConvert.SerializeObject(extractedDetails, Newtonsoft.Json.Formatting.Indented);
            scriptWriter.WriteLine(jsonSerializedText);
            scriptWriter.Close();
        }
    }
}
