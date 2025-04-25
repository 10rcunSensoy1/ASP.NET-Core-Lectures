using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ODEV1
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
        private void textYol_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnTara_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string dosyaYolu = textYol.Text.Trim();

            if (Directory.Exists(dosyaYolu))
            {
                foreach (var klasor in Directory.GetDirectories(dosyaYolu))
                {
                    listBox1.Items.Add("📂 " + Path.GetFileName(klasor));

                    foreach (var dosya in Directory.GetFiles(klasor, "*.cs"))
                    {
                        string dosyaAdi = Path.GetFileName(dosya);

                        foreach (var satir in File.ReadAllLines(dosya))
                        {
                            if (satir.Contains("class "))
                            {
                                string[] kelimeler = satir.Split(' ');
                                int index = Array.IndexOf(kelimeler, "class");
                                if (index != -1 && index + 1 < kelimeler.Length)
                                {
                                    listBox1.Items.Add("   🔹 " + dosyaAdi);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir klasör yolu giriniz!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}

