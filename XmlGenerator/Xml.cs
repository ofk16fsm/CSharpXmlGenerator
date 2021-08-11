using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace XmlGenerator
{
    class Xml
    {
        private XmlElement root;
        private XmlElement child;
        private XmlElement subChild;
        private readonly XmlDocument xmlDoc;
        private string filename;
        public Xml(string filename)
        {
            this.filename = filename;
            this.root = null;
            this.child = null;
            this.subChild = null;
            xmlDoc = new XmlDocument();
        }

        public void createRoot(string tagName)
        {
            root = xmlDoc.CreateElement(tagName);
            root.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            root.SetAttribute("xsi:noNamespaceSchemaLocation", "products.xsd");
            xmlDoc.AppendChild(root);
        }

        public void createChild(string tagName)
        {
            child = xmlDoc.CreateElement(tagName);
            root.AppendChild(child);

        }

        public void createSubChild(string tagName, string text)
        {
            subChild = xmlDoc.CreateElement(tagName);
            subChild.InnerText = text;
            child.AppendChild(subChild);
        }

        public XmlNodeList getElementsByXPath()
        {
            xmlDoc.Load(this.filename);
            return xmlDoc.SelectNodes(".//products/*");
        }

        public void deleteChild()
        {
            xmlDoc.Load(this.filename);
            XmlNode node = xmlDoc.DocumentElement;
            node.RemoveChild(node.FirstChild);
            xmlDoc.Save(this.filename);
        }

        public void deleteSubChild()
        {
            xmlDoc.Load(this.filename);
            XmlNode node = xmlDoc.DocumentElement.ChildNodes[0];
            node.RemoveChild(node.ChildNodes[0]);
            xmlDoc.Save(this.filename);
        }

        public void saveXml(string filename)
        {
            XmlDeclaration xmlDecl = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.InsertBefore(xmlDecl, root);            
            xmlDoc.Save(filename);
        }
        
        public void validateXml(RichTextBox tempRichTextBox)
        {            
            try
            {
                XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
                xmlReaderSettings.Schemas.Add("http://www.w3.org/2001/XMLSchema", "products.xsd");
                xmlReaderSettings.ValidationType = ValidationType.Schema;
                XmlReader xmlReader = XmlReader.Create(this.filename, xmlReaderSettings);
                
                xmlDoc.Load(xmlReader);

                ValidationEventHandler eventHandler = new ValidationEventHandler(XmlReaderSettings_ValidationEventHandler);
                xmlDoc.Validate(eventHandler);
                tempRichTextBox.Text = "XML fil är " + xmlDoc.SchemaInfo.Validity.ToString();
            }
            
            catch (XmlException xe)
            {
                Console.WriteLine(xe.Message);
            }
        }
        public void XmlReaderSettings_ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }
        }
    }
}
