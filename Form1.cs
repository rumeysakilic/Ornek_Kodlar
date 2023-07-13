namespace HesappMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = sayi1 * sayi2;
            label3.Text = sonuc.ToString();
        }

        private void SONUÇ_Click(object sender, EventArgs e)
        {

        }

        private void Topla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = sayi1 + sayi2;
            label3.Text = sonuc.ToString();
        }

        private void Çýkar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = sayi1 - sayi2;
            label3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            double sonuc = sayi1 / sayi2;
            label3.Text = sonuc.ToString();
        }
    }
}