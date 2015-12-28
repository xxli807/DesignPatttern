using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DesignPatttern.Stragety
{

    [TestClass]
    public class xmlDocument
    {
        [TestMethod]
        public void test()
        {
            order ord = new order();
            ord.name = "aaa\a";
            ord.description = "bbb";

            var xdec = new XDeclaration("1.0", "utf-8", "yes");
            
            // Create an element with no content
            XElement root = new XElement("Root");
            root.SetElementValue("name", ord.name);
            root.SetElementValue("description", ord.description);

            XDocument xdocument = new XDocument(xdec, root);


            using (var ms = new MemoryStream())
            using (var x = new XmlTextWriter(ms, new UTF8Encoding(false)) { Formatting = Formatting.Indented})
            {
                xdocument.Save(x);
                var sssss = Encoding.UTF8.GetString(ms.ToArray());
            }

            //XmlWriterSettings settings = new XmlWriterSettings();
            //settings.Encoding = Encoding.ASCII;
            //settings.ConformanceLevel = ConformanceLevel.Document;
            //settings.Indent = true;
            // settings.IndentChars = "\t";
            // settings.NewLineHandling = NewLineHandling.None;
            // settings.;

            //var ms = new MemoryStream();
            //XmlWriter xw = XmlTextWriter.Create(ms, settings);

             
            //xdocument.Save(xw);
            //var sss = ms.ToString();
             //= System.Text.ASCIIEncoding.ASCII.GetBytes();


        }


        private void convert(object obj)
        {
            var type = obj.GetType(); 
            var matchStrs = "\\\\";

            foreach (var pro in type.GetProperties())
            {
                var tt = pro.PropertyType;

                if (pro.PropertyType == typeof(String))
                {
                    var proValue = pro.GetValue(obj);
                    if (proValue != null)
                    {
                        var sss = proValue.ToString();
                         
                            string s = proValue.ToString().Replace(@"\", matchStrs);
                            pro.SetValue(obj, s);
                         
                    }
                }

            }
        }

    }




    public class order
    {
        public string name { get; set; }
        public string description { get; set; }
        public DateTime dateStart { get; set; }

    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }


}
