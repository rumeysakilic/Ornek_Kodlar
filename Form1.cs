using System.Xml.Linq;

namespace HavaKartı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string api = "64f7b25e7843ab45d515204b1911e48b";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Samsun&appid=" + api;
            XDocument weather = XDocument.Load(connection);
            var sicaklik = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label4.Text = sicaklik.ToString();

        }
    }
}