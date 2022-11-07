using HtmlAgilityPack;
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

namespace İnternettenVeriÇekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int toplam = 20;
            int counter = 0;
            if (comboBox1.Text == "1.Sayfa")
            {
                
                HtmlWeb website1 = new HtmlWeb();

                HtmlAgilityPack.HtmlDocument doc1 = website1.Load("http://www.acikbilim.com/category/dosyalar");

                var table1 = doc1.DocumentNode.SelectNodes("//ul[@class='aramaSonuc'] //li");
                var table2 = doc1.DocumentNode.SelectNodes("//section[@id='omc-main'] //article");

                HtmlWeb yaziWeb1 = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument yaziDoc;
                
                foreach (var item in table2)
                {
                    
                    var yaziLink1 = item.ChildNodes["a"].Attributes["href"].Value;

                    // var yaziLink1 = item.FirstChild.Attributes["href"].Value;
                    yaziDoc = yaziWeb1.Load(yaziLink1);

                    var yaziBaslik2 = yaziDoc.DocumentNode.SelectSingleNode("//article[@class='omc-inner-standard'] /h1").InnerText;

                    string adressss = @"C:\Users\bilal\Desktop\Makaleler\1.Sayfa\" + yaziBaslik2.Replace("\n", "").Replace("&#8221;", "").Replace("&#8220;", "")
                        .Replace("&#8230;", "").Replace(" &#8211;", "").Replace(".", "").Replace("\r", "").Replace("\\", "").Replace("/", "").Replace("\"", "")
                        .Replace(":", "").Replace("*", "").Replace("?", "").Replace("<", "").Replace(">", "").Replace("|", "") + ".txt";

                    StreamWriter dosya1 = new StreamWriter(adressss);

                    var table3 = yaziDoc.DocumentNode.SelectNodes("//article[@class='omc-inner-standard']/p ");


                    foreach (var item1 in table3)
                    {
                        string degisken = item1.InnerText.Replace("&#8217;", "").Replace("&#8230;", "").Replace(" &#8211;", "").Replace("&#8221;", "")
                            .Replace("&#8220;", "").Replace("&nbsp;", "").Replace("&#8212;", "").Replace("&#8216;", "").Replace(" - ", "-").Replace("\n"," ").Replace(" / ","/")
                            .Replace(" = ", "=").Replace(" - ", "-").Replace(" ! ", "! ").Replace(" ? ", "? ").Replace(" — ", "—").Replace("  "," ");
                        dosya1.Write(degisken);
                        timer1.Start();
                        

                    }
                    
                    dosya1.Close();
                    
                    //var yaziBaslik1 = yaziDoc.DocumentNode.SelectSingleNode("//div[@class='yazarDetay'] //h3").InnerText;

                    //int titleIndexBaslangici = yaziBaslik2.IndexOf("<a class=") + 34;

                    //var yazi_İcerik1 = yaziDoc.DocumentNode.SelectSingleNode("//div[@class='yazarHaberTxt']").InnerText;

                    //string adres1 = @"C:\Users\ynssylmz\Desktop\Yazarlar\Candaş Tolga Işık\" + yaziBaslik1.Replace("\n", "").Replace("\r", "").Replace("\\", "").Replace("/", "").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "") + ".txt";

                    //dosya1.WriteLine(yazi_İcerik1);
                    
                }
            }
                
            else if (comboBox1.Text == "2.Sayfa")
            {
                
                HtmlWeb website1 = new HtmlWeb();

                HtmlAgilityPack.HtmlDocument doc1 = website1.Load("http://www.acikbilim.com/category/dosyalar/page/2");

                var table1 = doc1.DocumentNode.SelectNodes("//ul[@class='aramaSonuc'] //li");
                var table2 = doc1.DocumentNode.SelectNodes("//section[@id='omc-main'] //article");

                HtmlWeb yaziWeb1 = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument yaziDoc;

                foreach (var item in table2)
                {
                    var yaziLink1 = item.ChildNodes["a"].Attributes["href"].Value;

                    // var yaziLink1 = item.FirstChild.Attributes["href"].Value;
                    yaziDoc = yaziWeb1.Load(yaziLink1);

                    var yaziBaslik2 = yaziDoc.DocumentNode.SelectSingleNode("//article[@class='omc-inner-standard'] /h1").InnerText;

                    string adressss = @"C:\Users\bilal\Desktop\Makaleler\2.Sayfa\" + yaziBaslik2.Replace("\n", "").Replace("&#8221;", "").Replace("&#8220;", "")
                        .Replace("&#8230;", "").Replace(" &#8211;", "").Replace(".", "").Replace("\r", "").Replace("\\", "").Replace("/", "").Replace("\"", "")
                        .Replace(":", "").Replace("*", "").Replace("?", "").Replace("<", "").Replace(">", "").Replace("|", "") + ".txt";

                    StreamWriter dosya1 = new StreamWriter(adressss);

                    var table3 = yaziDoc.DocumentNode.SelectNodes("//article[@class='omc-inner-standard']/p ");


                    foreach (var item1 in table3)
                    {
                        string degisken = item1.InnerText.Replace("&#8217;", "").Replace("&#8230;", "").Replace(" &#8211;", "").Replace("&#8221;", "")
                            .Replace("&#8220;", "").Replace("&nbsp;", "").Replace("&#8212;", "").Replace("&#8216;", "").Replace(" - ", "-");
                        dosya1.Write(degisken);

                    }
                    dosya1.Close(); 
                }
            }
            else if (comboBox1.Text == "3.Sayfa")
            {

                HtmlWeb website1 = new HtmlWeb();

                HtmlAgilityPack.HtmlDocument doc1 = website1.Load("http://www.acikbilim.com/category/dosyalar/page/3");

                var table1 = doc1.DocumentNode.SelectNodes("//ul[@class='aramaSonuc'] //li");
                var table2 = doc1.DocumentNode.SelectNodes("//section[@id='omc-main'] //article");

                HtmlWeb yaziWeb1 = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument yaziDoc;

                foreach (var item in table2)
                {
                    var yaziLink1 = item.ChildNodes["a"].Attributes["href"].Value;

                    // var yaziLink1 = item.FirstChild.Attributes["href"].Value;
                    yaziDoc = yaziWeb1.Load(yaziLink1);

                    var yaziBaslik2 = yaziDoc.DocumentNode.SelectSingleNode("//article[@class='omc-inner-standard'] /h1").InnerText;

                    string adressss = @"C:\Users\bilal\Desktop\Makaleler\3.Sayfa\" + yaziBaslik2.Replace("\n", "").Replace("&#8221;", "").Replace("&#8220;", "")
                        .Replace("&#8230;", "").Replace(" &#8211;", "").Replace(".", "").Replace("\r", "").Replace("\\", "").Replace("/", "").Replace("\"", "")
                        .Replace(":", "").Replace("*", "").Replace("?", "").Replace("<", "").Replace(">", "").Replace("|", "") + ".txt";

                    StreamWriter dosya1 = new StreamWriter(adressss);

                    var table3 = yaziDoc.DocumentNode.SelectNodes("//article[@class='omc-inner-standard']/p ");

                    
                    foreach (var item1 in table3)
                    {
                        string degisken = item1.InnerText.Replace("&#8217;", "").Replace("&#8230;", "").Replace(" &#8211;", "").Replace("&#8221;", "")
                            .Replace("&#8220;", "").Replace("&nbsp;", "").Replace("&#8212;", "").Replace("&#8216;", "").Replace(" - ", "-");
                        dosya1.Write(degisken);
                       
                    }
                    counter++;

                    progressBar1.Value = counter*100/20;


                   
                    dosya1.Close();
                   
                }
            }
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        { 
          
            
           
            
           
           
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
