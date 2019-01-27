using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = "Emre";
            char karakter = 'E';
            karakter = '&';
            bool lojik = false;
            byte kucukrakam = 255; // 0 ile 255 arası değer alır
            short ufakrakam = 32000; // -32000 ile +32000 arası değer alır
            int rakam = 100; // 8 byte yer tutar int değişken -2 milyar ile + 2 milyar arası değer alır
            long buyukrakam = 10000000; // -1.9*10e18 ile 1.9*10e18

            double ondaliksayi = 12.45d; //+-5*10e324.1.7*10e308 arası değer alır // önüne suffix ekliyoruz (d double) 
            //double varsayılan ondalıklı sayı olduğu için suffix eklememize gerek yoktur opsiyoneldir
            float ufakondalik = 23.45f; // önüne suffix ekliyoruz (f float) 
            decimal enbuyuksayi = 2345345436m; // önüne suffix ekliyoruz (m)

            //C# tüm nesneler object dir
            object sayi = 22;
            object kelime = "kelime";
            object tarih = new DateTime(1991, 09, 25);

            DateTime bugun = DateTime.Now;
            MessageBox.Show(bugun.ToString()); // Anlık zamanı göster MessageBox'ta
            DateTime dogumgunum = new DateTime(1991, 09, 25);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 12;
            int b = 26;
            int c = a+b; //c 38 değeri aldı
            c = b - a; // c 14 değeri alır
            c = a * b;
            c = a / b;
            a = a + 5; // a değişkenini 5 artır
            a += 5; // yukarıdaki satırın aynı işini yapar
            a = -4;

            a *= 4; // a değişkeninin 4 katı
            a/=2; // a değişkenin yarısını al
            a+=1; // a değişenini 1 artır
            a++; //yukarıdaki satırın aynı işini yapar
            a -= 1; // a değişkenini 1 azalt
            a--; // a değişkenini 1 azalt 

            a = 20;
            b = a++; // burada b 20, a:21 önce eşitledi sonra artırdı
            a = 20;
            b = ++a; // burada b:21, - a:21 önce artırdı sonra eşitledi 

            string yazi = textBox1.Text;
            MessageBox.Show(yazi);
        }
    }
}
