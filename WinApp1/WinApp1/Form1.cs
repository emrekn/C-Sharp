using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = "Emre"; //String Değer Tanımlama
            string soyisim = "EMANET";
            MessageBox.Show(isim+" "+soyisim); //String Değerleri Ekrana Bas
            MessageBox.Show("merhaba dünya");         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string textBoxtanYazilariAl = textBox1.Text;
        }

        void temizle()
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TextBox'ı temizleme fonksiyonunu çağır
            temizle();
        }
    }
}
