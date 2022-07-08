using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_IP_Adress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> tarifs = new List<string>();

        private void button1_Click_1(object sender, EventArgs e)
        {
            string result = "";
            string parsedSite = "";
            string path = $"http://ipwhois.app/xml/{tbIP.Text}";

            // Записали всю инфу с сайта
            using (WebClient wc = new WebClient())
            {
                parsedSite = wc.DownloadString(path);
            }

            // Создаем маску
            Regex regex = new Regex("<id>(.*?)</id>");

            //Создаем единственный экземпляр совпадения
            Match match = regex.Match(parsedSite);

            result = $"Континент: {match.Groups[1].Value}; Код телефона: {match.Groups[3].ToString()}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            foreach (var item in tarifs)
            {
                string request = $"http://ipwhois.app/xml/{item}";

                // Записали всю инфу с сайта
                using (WebClient wc = new WebClient())
                {
                    parsedSite = wc.DownloadString(request);
                }
            }
        }
    }
}
