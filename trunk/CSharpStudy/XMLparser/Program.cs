using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace XMLparser
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Parse();
            Console.Read();
        }

        public void Parse()
        {
            FileStream fs = null;
            XmlReader xmlReader = null;
            XmlReaderSettings settings = null;

            try
            {
                fs = new FileStream(@"C:\_Work\Others\リンクデータ取得ツール\input\xml2.txt", FileMode.Open);

                settings = new XmlReaderSettings();
                settings.IgnoreComments = true;
                settings.IgnoreWhitespace = true;

                xmlReader = XmlReader.Create(fs, settings);
                while (xmlReader.Read() == true)
                {
                    XmlNodeType nType = xmlReader.NodeType;
                    Console.WriteLine("NodeType: " + nType.ToString() + "\r\n");

                    Console.WriteLine("LocalName: " + xmlReader.LocalName + "\r\n");
                    Console.WriteLine("Depth: " + Convert.ToString(xmlReader.Depth) + "\r\n");
                    Console.WriteLine("Name: " + xmlReader.Name + "\r\n");
                    if (xmlReader.HasValue == true)
                    {
                        Type valueType = xmlReader.ValueType;
                        Console.WriteLine("ValueType: " + valueType.ToString() + "\r\n");
                        Console.WriteLine("Value: " + xmlReader.Value + "\r\n");
                    }

                    //属性がある場合
                    if (xmlReader.HasAttributes == true)
                    {
                        for (int i = 0; i < xmlReader.AttributeCount; i++)
                        {
                            xmlReader.MoveToAttribute(i);
                            Console.WriteLine("Attribute Name: " + xmlReader.Name + "\r\n");
                            if (xmlReader.HasValue == true)
                            {
                                Type valueType = xmlReader.ValueType;
                                Console.WriteLine("ValueType: " + valueType.ToString() + "\r\n");
                                Console.WriteLine("Attribute Value: " + xmlReader.Value + "\r\n");
                            }
                        }
                        xmlReader.MoveToElement();
                    }

                    Console.WriteLine("\r\n");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error: " + exc.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
            }
        }
    }
}
