using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;


namespace ODEV1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void DeSerializebutton_Click(object sender, EventArgs e)
        {
            string jsonPath = "Urunler.json";
            if (File.Exists(jsonPath))
            {
                
               
                string jsonString = File.ReadAllText(jsonPath);

                //Dosyayi DeSerialize et
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

                //Urunleri Listbox'a ekliyoruz
                listboxURUNLER.Items.Clear();
                foreach (var urun in urunler)
                {
                    listboxURUNLER.Items.Add($"{urun.UrunAdi} - {urun.Fiyat} TL");
                }
            }
            else
            {
                MessageBox.Show($"Bir hata olustu tekrar kontrol et: {jsonPath}");
            }
        }

        private void listboxURUNLER_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
