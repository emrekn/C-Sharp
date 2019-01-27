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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void calisma()
        {
            //diziler 
            string[] isimlerDizisi = new string[16];
            isimlerDizisi[0] = "Ahmet";
            isimlerDizisi[1] = "Aslı";
            isimlerDizisi[15] = "Recep";
            string ikinciIsım = isimlerDizisi[1];

            string[] meyveler = new string[] { "elma", "armut", "kivi" };
            //{dizi tanımlama elemanları} initializer

            //listeler
            List<string> isimlistesi = new List<string>();
            isimlistesi.Add("Emre");
            isimlistesi.Add("Mehmet");

            isimlistesi[1] = "1";
            string ilkEleman = isimlistesi[0];
            string isim = isimlerDizisi[10];
            int isimSayisi = isimlerDizisi.Length; // isimler dizisi kaç elemanlı olduğunu alıyoruz
            string sonIsim = isimlerDizisi[isimSayisi - 1];
            sonIsim = isimlerDizisi[isimlerDizisi.Length - 1];


            listBox1.Items.Add("Hatice");
            string listedekiIlkIsim = listBox1.Items[0].ToString();
            string SonIsim = listBox1.Items[listBox1.Items.Count -1].ToString();
            int listboxdakiElemanSayisi = listBox1.Items.Count; // list boxtaki eleman sayısını verir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string akademi = "BTAkademi yazılım eğitim kurumu";
            int kacKarakter = akademi.Length; //kaç karakterli bir kelime olduğunu ver
            bool denetle = akademi.Contains("yazılım"); // yazılım kelimesi akademi değişkenin içinde yazılım kelimesi var mı

            bool denetle2 = akademi.Contains("ddd"); // false döner
            bool bitisKelimesi = akademi.EndsWith("vvv");
            bool baslangicKelimesi = akademi.StartsWith("BTAkademi"); // başlangıçtaki kelime BTAkademi ile başlıyor mu
            int  IndexSay = akademi.IndexOf("Yazılım");
            string isim = "Emre Emanet";
            isim.Insert(0, "Ahmet"); //Adımın başına Ahmet kelimesini ekler

            int yazilimIndexi = akademi.IndexOf("Yazılım");
            akademi = akademi.Insert(yazilimIndexi, "Sistem "); //BTAkademi sistem yazılım eğitim kurumu şeklinde sonuç verir

            akademi = akademi.Remove(0, 10); // yukarıdaki yazı  Yazılım Sistem Eğitim Kurumu şeklinde sonuç verir
            akademi.Replace("kurumu", "binası");
            akademi.Replace("binası", "");
            string egitimKelimesi = akademi.Substring(7,6);
            string akademiKelimesininIlkUcHarfi = akademi.Substring(akademi.IndexOf("akademisi"),3); // akademi kelimesinin ilk üç harfini alır

            akademi = akademi.ToUpper(); // BÜYÜK HARFE ÇEVİRİR
            akademi = akademi.ToLower(); // küçük harfe çevirir
            string adSoyad = "     Ahmet Aydın   ";
            adSoyad = adSoyad.TrimStart(); //"Ahmet Aydın" Baştaki boşluğu sil
            adSoyad = adSoyad.TrimEnd();//"Ahmet Aydın"  sondaki boşluğu sil,
            adSoyad = adSoyad.Trim(); // baştaki ve sondaki boşlukları siler


            // String birleştirmek

            string name = "Emre";
            string surname = "Emanet";
            string fullname = name + "" + surname;



            fullname = string.Concat(name, "", surname);
            fullname = string.Format("{0}, {1}", name, surname);
            fullname = $"{name} {surname}"; // string formatın C# 6.0 ile gelen özelliği

        }
    }
}
