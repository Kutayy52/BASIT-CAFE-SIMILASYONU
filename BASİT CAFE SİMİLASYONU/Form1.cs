namespace BASİT_CAFE_SİMİLASYONU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int su=2, kahve=10, limonata=9, ayran=6, çay=5;
            double hesap = (su * Convert.ToInt32(textBox1.Text))+(kahve * Convert.ToInt32(textBox2.Text)+limonata * Convert.ToInt32(textBox3.Text)+ayran * Convert.ToInt32(textBox4.Text)+çay * Convert.ToInt32(textBox5.Text));
            textBox6.Text=hesap.ToString()+ "  TL";
            kasatutar = kasatutar + hesap;

            label18.Text = kasatutar.ToString();
          
        }
    }
}