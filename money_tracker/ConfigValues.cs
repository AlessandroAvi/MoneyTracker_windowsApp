using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace money_tracker
{
    public class KeyValue
    {
        public string name;
        public int value;

        public KeyValue(string _name, int _value)
        {
            name = _name;
            value = _value;
        }
    }




    public class ConfigValues
    {
        public string csvPath = @"C:\Users\aless\Documents\Projects\csharp_code\money_tracker\data\money_database.csv";
        public string xmlPath = @"C:\Users\aless\Documents\Projects\csharp_code\money_tracker\data\configurations.xml";

        public string cfgPath = @"C:\Users\aless\Documents\Projects\csharp_code\money_tracker\data";

        public List<KeyValue> categories;
        public List<KeyValue> modalities;
        


        public ConfigValues()
        {
            
            categories = new List<KeyValue>();
            /*
            categories.Add(new KeyValue("RENT", 0));
            categories.Add(new KeyValue("GROCERIES", 1));
            categories.Add(new KeyValue("LIVING", 2));
            categories.Add(new KeyValue("TRANSPORT", 3));
            categories.Add(new KeyValue("SPORT", 4));
            categories.Add(new KeyValue("OTHER", 5));
            */

            modalities = new List<KeyValue>();

            /*
            modalities.Add(new KeyValue("CASH", 0));
            modalities.Add(new KeyValue("PAYPAL", 1));
            modalities.Add(new KeyValue("PP CARD", 2));
            modalities.Add(new KeyValue("CC CARD", 3));
            */




            writeXml();
        }



        public void writeXml()
        {
            XmlTextWriter textWriter = new XmlTextWriter(xmlPath, null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.WriteStartDocument();
            textWriter.WriteComment("This file contains all the configurations for the money tracker app");
            textWriter.WriteStartElement("CSVPATH");
            textWriter.WriteString(csvPath);
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }


        public void writeXml_path()
        {

        }

        public void readXml_categories()
        {
            string path = cfgPath + @"\categories.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList nodeList = doc.SelectNodes("//text()");

            foreach (XmlNode node in nodeList)
            {
                categories.Add(new KeyValue(node.ParentNode.Name, Convert.ToInt32(node.InnerText)));
            }
        }

        public void writeXml_categories()
        {
            string path = cfgPath + @"\categories.xml";
            XmlTextWriter textWriter = new XmlTextWriter(path, null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("Data");
            foreach (var elem in categories)
            {
                textWriter.WriteStartElement(elem.name);
                textWriter.WriteString(elem.value.ToString());
                textWriter.WriteEndElement();
            }
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }

        public void readXml_modalities()
        {
            string path = cfgPath + @"\modalities.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList nodeList = doc.SelectNodes("//text()");

            foreach (XmlNode node in nodeList)
            {
                modalities.Add(new KeyValue(node.ParentNode.Name, Convert.ToInt32(node.InnerText)));
            }
        }

        public void writeXml_modalities()
        {
            string path = cfgPath + @"\modalities.xml";
            XmlTextWriter textWriter = new XmlTextWriter(path, null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("Data");
            foreach (var elem in modalities)
            {
                textWriter.WriteStartElement(elem.name);
                textWriter.WriteString(elem.value.ToString());
                textWriter.WriteEndElement();
            }
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }


        public void loadXml()
        {

        }


    }
}
