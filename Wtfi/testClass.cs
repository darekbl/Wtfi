using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace Wtfi
{
    class testClass
    {
        public string testString { get; set; }
        public int testInt { get; set; }
        
        TextBox keyBox = new TextBox();

        public testClass(string testString="", int testInt=1)
        {
            this.testString = testString;
            this.testInt = testInt;
        }

        public static void Test(TextBox keyBox, TextBox valueBox, string fileName)
        {
            XmlTextReader reader;

            try
            {
                reader = new XmlTextReader(fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                reader = null;
                MessageBox.Show(e.Message);
            }
            
            if(reader != null)
            while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            keyBox.AppendText(reader.Name + "\n");
                            Console.WriteLine("Element");
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            valueBox.AppendText(reader.Value + "\n");
                            Console.WriteLine("Text");
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            //keyBox.AppendText(reader.Name + "\n");
                            Console.WriteLine("EndElement");
                            break;
                    }
                }
            return;
        }
    }
}
