using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlTiedostonLuku
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Luodaan uusi XML-olio
            XmlDocument myXML = new XmlDocument();

            //Ladataan tiedot ko. polku\tiedosto :sta
            myXML.Load(@"C:\Users\OWNER\Google Drive\PointCollege\Kurssi_05_Ohjelmoinnin jatkokurssi\menu.xml");

            //Tulostetaan tiedot ruudulle
            // Tähti (*) tuo ruudulle kaikki tiedot ("name":n sijasta)
            // Ensin xml -koodin sitten tekstisisällön "selväkielisenä"

            XmlNodeList list = myXML.GetElementsByTagName("name");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].InnerXml);
            }
            Console.ReadLine();

            //Lisään tänne vähän kommenttia ja sitten teen uuden versiotallennuksen.

        }
    }
}
