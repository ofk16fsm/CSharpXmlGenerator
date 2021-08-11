using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace XmlGenerator
{
    public partial class Form1 : Form
    {
        private readonly Xml xml;
        private List<Product> products;
        private const string FILENAME = "products.xml";
        public Form1()
        {
            InitializeComponent();
            xml = new Xml(FILENAME);
            products = new List<Product>();            
            txtBoxFilename.Text = FILENAME;
            var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
            lblInfo.Text = "Den här applikationen skapar en XML-fil för film produkter.\n" +
                "Instruktionen är följande:\n" +
                "1. Använd textboxar för att mata in värdena \t 2. Lägg värdena i XML listan\n" +
                "3. Skapa XML filen 4. Läsa XML filen 5. Ta bort första noden\n" + "6. Spara XML filen 7. Validera XML filen";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            xml.saveXml(txtBoxFilename.Text);
        }

        private void btnRemoveChild_Click(object sender, EventArgs e)
        {
            xml.deleteChild();
        }

        private void btnRemoveSubchild_Click(object sender, EventArgs e)
        {
            xml.deleteSubChild();
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            richTextBoxXml.Clear();
            XmlNodeList xmlNodeList = xml.getElementsByXPath();
            foreach (XmlElement elem in xmlNodeList)
            {
                foreach(XmlElement c_elem in elem.ChildNodes)
                {
                    string info = $"{c_elem.Name}: {c_elem.InnerText}\n";
                    richTextBoxXml.Text += info;
                }                               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            products.Add(new Product
            {
                Id = int.Parse(txtBoxId.Text),
                Name = txtBoxName.Text,
                Price = int.Parse(txtBoxPrice.Text),
                Type = txtBoxType.Text,
                Playtime = int.Parse(txtBoxPlaytime.Text)
            }); 
            /*
            products.Add(new Product
            {
                Id = 202102,
                Name = "Gudfadern",
                Price = 99,
                Type = "DVD",
                Playtime = 152
            });
            products.Add(new Product
            {
                Id = 102342,
                Name = "Pulp fiction",
                Price = 99,
                Type = "DVD",
                Playtime = 154
            });
            products.Add(new Product
            {
                Id = 201548,
                Name = "Schindlers list",
                Price = 149,
                Type = "DVD",
                Playtime = 195
            });
            */
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            xml.createRoot("products");
            foreach (var pr in products)
            {
                xml.createChild("product");
                xml.createSubChild("id", pr.Id.ToString());
                xml.createSubChild("name", pr.Name);
                xml.createSubChild("price", pr.Price.ToString());
                xml.createSubChild("type", pr.Type);
                xml.createSubChild("playtime", pr.Playtime.ToString());
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            xml.validateXml(richTextBoxXml);
        }

    }
}
