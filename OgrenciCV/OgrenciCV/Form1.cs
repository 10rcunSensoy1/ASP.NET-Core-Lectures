using OgrenciCV.Classes;

namespace OgrenciCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OgrenciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciBolumu_TextChanged(object sender, EventArgs e)
        {

        }

        private void SonucButton_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = OgrenciAdi.Text,
                Soyad = OgrenciSoyadi.Text,
                Bolum = OgrenciBolumu.Text
            };

            string hataMesaji = KontrolEt(ogrenci);

            if (!string.IsNullOrEmpty(hataMesaji))
            {
                MessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SonucLabel.Text = $"Öðrenci: {ogrenci.Ad} {ogrenci.Soyad}, Bölüm: {ogrenci.Bolum}";
            }

        }
        private string KontrolEt(Ogrenci ogrenci)
        {
            var properties = typeof(Ogrenci).GetProperties();

            foreach (var prop in properties)
            {
                var attribute = (ZorunluAlanAttribute)Attribute.GetCustomAttribute(prop, typeof(ZorunluAlanAttribute));
                var deger = prop.GetValue(ogrenci) as string;

                if (attribute != null && string.IsNullOrWhiteSpace(deger))
                {
                    return attribute.HataMesaji;
                }
            }

            return null;
        }


        private void SonucLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
