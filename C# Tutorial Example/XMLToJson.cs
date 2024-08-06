using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System;
using InsuranceDetailsExtractor;
using XML_Extractor;



namespace InsuranceListExtractionExample
{
    public class XMLToJson
    {
        static void Main(string[] args)
        {
            XMLDeserializer<InsuranceList> xmlDeserializer = new XMLDeserializer<InsuranceList>();

            string filePathXML = @"c:\Testing\MyXML.xml";
            InsuranceList insuranceList = xmlDeserializer.ExtractFromXML(filePathXML);
            Console.WriteLine("Extraction Completed.");

            string filePathJson = @"c:\Testing\MyJson.json";
            xmlDeserializer.ToJSON(insuranceList,filePathJson);
            Console.WriteLine("Converted to JSON");

            ReadKey();
        }
    }
}

