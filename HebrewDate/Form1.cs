using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace HebrewDate
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDocument;
        XmlNode root;
        string pathName = Directory.GetCurrentDirectory() + "\\dateData.xml";
        public Form1()
        {

            InitializeComponent();
            xmlDocument = new XmlDocument();
            if (File.Exists(pathName))
            {
                try
                {
                    xmlDocument.Load(pathName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eror loading xml file:" + ex.Message);
                }
            }
            else
            {
                XmlNode root = xmlDocument.CreateElement("queries");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(pathName);
            }

        }

        private  bool CreateDate(XmlNode root)
        {
           
                XmlNode query = xmlDocument.CreateElement("query");


                XmlNode day =  xmlDocument.CreateElement("day");
                   
                day.InnerText = cmbweekday.Text;

                XmlNode daymonth = xmlDocument.CreateElement("daymonth");
                daymonth.InnerText = cmbmonthday.Text;

                XmlNode month = xmlDocument.CreateElement("month");
                month.InnerText = cmbmonth.Text;


                XmlNode year = xmlDocument.CreateElement("year");
                year.InnerText = cmbyear.Text;

                XmlNode result = xmlDocument.CreateElement("result");
                result.InnerText = 
                


                query.AppendChild(day);
                query.AppendChild(daymonth);
                query.AppendChild(month);
                query.AppendChild(year);
               

                xmlDocument.FirstChild.AppendChild(query);
            
            
            return true;

        }

        private void ChangeWeekDay()
        {
         
             string weekday = "";

              
                    switch (cmbweekday.Text)
                    {
                        case "ראשון":

                            weekday = "אחד";
                            break;
                       
                    }
                
             
            
        }
        private void ChangeMonthDay()
        {
            string monthday = "";

            switch (cmbmonthday.Text)
            {
                case "1":
                    monthday = "אחד";
                    break;
                case "2":
                    monthday = "שני";
                    break;
                case "3":
                    monthday = "שלשה";
                    break;
                case "4":
                    monthday = "ארבעה";
                    break;
                case "5":
                    monthday = "חמשה";
                    break;
                case "6":
                    monthday = "ששה";
                    break;
                case "7":
                    monthday = "שבעה";
                    break;
                case "8":
                    monthday = "שמנה";
                    break;
                case "9":
                    monthday = "תשעה";
                    break;
                case "10":
                    monthday = "עשרה";
                    break;
                case "11":
                    monthday = "אחד עשר";
                    break;
                case "12":
                    monthday = "שנים עשר";
                    break;
                case "13":
                    monthday = "שלשה עשר";
                    break;
                case "14":
                    monthday = "ארבעה עשר";
                    break;
                case "15":
                    monthday = "חמשה עשר";
                    break;
                case "16":
                    monthday = "ששה עשר";
                    break;
                case "17":
                    monthday = "שבעה עשר";
                    break;
                case "18":
                    monthday = "שמנה עשר";
                    break;
                case "19":
                    monthday = "תשעה עשר";
                    break;
                case "20":
                    monthday = "עשרים";
                    break;
                case "21":
                    monthday = "אחד ועשרים";
                    break;
                case "22":
                    monthday = "שנים ועשרים";
                    break;
                case "23":
                    monthday = "שלשה ועשרים";
                    break;
                case "24":
                    monthday = "ארבעה ועשרים";
                    break;
                case "25":
                    monthday = "חמשה ועשרים";
                    break;
                case "26":
                    monthday = "ששה ועשרים";
                    break;
                case "27":
                    monthday = "שבעה ועשרים";
                    break;
                case "28":
                    monthday = "שמונה ועשרים";
                    break;
                case "29":
                    monthday = "תשעה ועשרים";
                    break;
                case "30":
                    monthday = "שלשים";
                    break;
            }

        }


        private void ChangeYear()
        {
            string monthday = "";
                switch (cmbyear.Text)
                {
                     case"תשפד":
                    monthday = "חמשת אלפים ושבע מאות ושמנים וארבע";
                        break;
                    case "תשפה":
                        monthday = "חמשת אלפים ושבע מאות ושמנים וחמש";
                        break;
                    case "תשפו":
                        monthday = "חמשת אלפים ושבע מאות ושמנים ושש";
                        break;
                    case "תשפז":
                        monthday = "חמשת אלפים ושבע מאות ושמנים ושבע";
                        break;
                }

        }


           

    }
    
}
