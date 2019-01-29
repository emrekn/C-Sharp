using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDers1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Calisma();
        }

        void Calisma()
        {
            // diziler
            string[] isimlerDizisi = new string[16];
            isimlerDizisi[0] = "Ahmet";
            isimlerDizisi[1] = "Asli";
            isimlerDizisi[15] = "Recep";
            string ikinciIsim = isimlerDizisi[1];
            string isim = isimlerDizisi[10];
            int isimSayisi = isimlerDizisi.Length; // isimDizisi nin kac elemanli oldugunu aliyoruz.
            string sonIsim = isimlerDizisi[isimSayisi - 1];
            sonIsim = isimlerDizisi[isimlerDizisi.Length - 1];

            string[] meyveler = new string[] { "Elme", "Mandalina", "Armut" };
            meyveler[0] = "Incir";

            // list
            List<string> isimListesi = new List<string>();
            isimListesi.Add("Emre");
            isimListesi.Add("Ahmet");
            isimListesi[1] = "Cigdem";
            string ilkEleman = isimListesi[0];
            int isimListesiElemanSayisi = isimListesi.Count;

            listBox1.Items.Add("Emre");
            string listedekiIlkIsim = listBox1.Items[0].ToString();
            int listboxdakiElemanSayisi = listBox1.Items.Count;
            string listboxdakiSonIsim = listBox1.Items[listBox1.Items.Count - 1].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string akademi = "BtAkademi Yazilim Egitim Kurumu";
            int kacKarakter = akademi.Length; // karakter sayisini verir.
            bool yazilimGeciyormu = akademi.Contains("Yazilim"); // Yazilim kelimesinin gecip gecmedigine baktik: true donecek
            bool sistemGeciyormu = akademi.Contains("Sistem"); // false donecek
            bool kurumuKelimesiIleBitiyormu = akademi.EndsWith("Kurumu");//true
            bool btakaddemiIleBasliyormu = akademi.StartsWith("btAkademi");//false
            int yazilimKelimesininIndexi = akademi.IndexOf("Yazilim");//10 donecek
            listBox1.Items.Add(yazilimKelimesininIndexi);
            string isim = "Emre Tekinsoy";
            isim = isim.Insert(0, "Mustafa ");
            listBox1.Items.Add(isim);

            // Senaryo: yazilim kelimesinden once Sistem kelimesini eklemek istiyoruz.
            int yaziliminIndexi = akademi.IndexOf("Yazilim");
            listBox1.Items.Add(yaziliminIndexi);
            akademi = akademi.Insert(yaziliminIndexi, "Sistem ");
            listBox1.Items.Add(akademi);

            akademi = akademi.Remove(0, 10);// Yazilim Sistem Egitim Kurumu
            listBox1.Items.Add(akademi);
            akademi = akademi.Replace("Kurumu", "Akademisi");// Yazilim Sistem Egitim Akademisi
            listBox1.Items.Add(akademi);
            akademi = akademi.Replace("Sistem ", ""); // Yazilim Egitim Akademisi
            listBox1.Items.Add(akademi);
            string egitimKelimesi = akademi.Substring(8, 6);
            listBox1.Items.Add(egitimKelimesi);
            string akademiKelimesininIlkUcHarfi = akademi.Substring(akademi.IndexOf("Akademisi") , 3);// Aka
            listBox1.Items.Add(akademiKelimesininIlkUcHarfi);

            akademi = akademi.ToUpper();
            akademi = akademi.ToLower();
            string AdSoyad = "   Ahmet Aydin    ";
            string ad = AdSoyad.TrimStart();// "Ahmet Aydin    "
            ad = AdSoyad.TrimEnd(); // "   Ahmet Aydin"
            ad = AdSoyad.Trim(); //"Ahmet Aydin"

            // String birlestirmek
            string name = "Emre";
            string surname = "Tekinsoy";
            string fullname = name + " " + surname; // en kotu string birlestirme yontemi
            fullname = string.Concat(name, " ", surname); // daha iyi bir yontem
            fullname = string.Format("{0} {1}", name, surname); // en iyi den bir once
            fullname = $"Sayin {name} {surname}, 1.1.2019 tarihinde {AdSoyad} isimli elemani tanistinizmi."; // string.Format in 6.0 ile gelen alternatifi: en iyisi

            // Escape Characters
            MessageBox.Show("Dersimiz \"C#\" dir");
            MessageBox.Show("\tSayin Kullanici,\r\n\tSistemMesgul\r\nSonra Yeniden Dene.");
            MessageBox.Show("Muzikler D:\\\\Media\\Muzik kalsorunde");

            string mvcProjeAdresi = @"C:\Users\BTAkademi\source\repos\MvcSessionCookie";
        }
    }
}
