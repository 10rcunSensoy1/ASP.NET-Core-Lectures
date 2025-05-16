using Microsoft.Data.SqlClient;
namespace HastaRandevuFormu
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=ORCUNSENSOY\\SQLEXPRESS_2019;Database=HastaRandevuDB;User ID=sa;Password=Arifv216;TrustServerCertificate=True;";



        public Form1()
        {
            InitializeComponent();
            YükleBranslar();
        }
        private void YükleBranslar()
        {
            cmbBranslar.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, BransAdi FROM Branslar", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbBranslar.Items.Add(new ComboBoxItem
                    {
                        Text = reader["BransAdi"].ToString(),
                        Value = reader["Id"]
                    });
                }

                conn.Close();
            }
        }
        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.Clear();
            cmbTarihler.Items.Clear();
            cmbSaatler.Items.Clear();
            cmbTarihler.Enabled = false;
            cmbSaatler.Enabled = false;
            btnRandevuOlustur.Enabled = false;

            var brans = cmbBranslar.SelectedItem as ComboBoxItem;
            if (brans == null) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, DoktorAdi, DoktorSoyadi FROM Doktorlar WHERE BransID = @bransId", conn);
                cmd.Parameters.AddWithValue("@bransId", brans.Value);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string doktorAd = reader["DoktorAdi"] + " " + reader["DoktorSoyadi"];
                    cmbDoktorlar.Items.Add(new ComboBoxItem
                    {
                        Text = doktorAd,
                        Value = reader["Id"]
                    });
                }

                conn.Close();
            }
        }
        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTarihler.Items.Clear();
            cmbSaatler.Items.Clear();
            cmbTarihler.Enabled = true;
            cmbSaatler.Enabled = false;
            btnRandevuOlustur.Enabled = false;

            var doktor = cmbDoktorlar.SelectedItem as ComboBoxItem;
            if (doktor == null) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT CONVERT(date, Tarih) as RandevuTarihi FROM Randevular WHERE DoktorID = @doktorId", conn);
                cmd.Parameters.AddWithValue("@doktorId", doktor.Value);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime tarih = Convert.ToDateTime(reader["RandevuTarihi"]);
                    cmbTarihler.Items.Add(tarih.ToShortDateString());
                }

                conn.Close();
            }
        }
        private void cmbTarihler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSaatler.Items.Clear();
            cmbSaatler.Enabled = true;
            btnRandevuOlustur.Enabled = false;

            string seciliTarihStr = cmbTarihler.SelectedItem.ToString();
            DateTime seciliTarih = DateTime.Parse(seciliTarihStr);

            var doktor = cmbDoktorlar.SelectedItem as ComboBoxItem;
            if (doktor == null) return;

            // Sabit saatler (örnek olarak)
            List<string> tumSaatler = new List<string>();
            if (seciliTarih.Hour < 12)
                tumSaatler.AddRange(new[] { "09:00", "10:00", "11:00" }); // sabah
            else
                tumSaatler.AddRange(new[] { "14:00", "15:00", "16:00" }); // öðleden sonra

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (var saat in tumSaatler)
                {
                    DateTime saatliTarih = DateTime.Parse($"{seciliTarih:yyyy-MM-dd} {saat}");

                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Randevular WHERE DoktorID = @doktorId AND Tarih = @tarih", conn);
                    cmd.Parameters.AddWithValue("@doktorId", doktor.Value);
                    cmd.Parameters.AddWithValue("@tarih", saatliTarih);

                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        cmbSaatler.Items.Add(saat);
                    }
                }

                conn.Close();
            }
        }
        private void cmbSaatler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRandevuOlustur.Enabled = true;
        }


        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (cmbBranslar.SelectedItem == null || cmbDoktorlar.SelectedItem == null || cmbTarihler.SelectedItem == null || cmbSaatler.SelectedItem == null || string.IsNullOrWhiteSpace(txtHastaAdi.Text) || string.IsNullOrWhiteSpace(txtHastaSoyadi.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.");
                return;
            }

            var bransId = (cmbBranslar.SelectedItem as ComboBoxItem).Value;
            var doktorId = (cmbDoktorlar.SelectedItem as ComboBoxItem).Value;
            string hastaAdi = txtHastaAdi.Text.Trim();
            string hastaSoyadi = txtHastaSoyadi.Text.Trim();

            DateTime randevuSaati = DateTime.Parse($"{cmbTarihler.SelectedItem} {cmbSaatler.SelectedItem}");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand kontrolCmd = new SqlCommand("SELECT COUNT(*) FROM Randevular WHERE DoktorID = @doktorId AND Tarih = @tarih", conn);
                    kontrolCmd.Parameters.AddWithValue("@doktorId", doktorId);
                    kontrolCmd.Parameters.AddWithValue("@tarih", randevuSaati);

                    int sayi = (int)kontrolCmd.ExecuteScalar();
                    if (sayi > 0)
                    {
                        MessageBox.Show("Bu doktorun bu saatte zaten randevusu var!");
                        return;
                    }

                    SqlCommand ekleCmd = new SqlCommand("INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) VALUES (@hastaAdi, @hastaSoyadi, @bransId, @doktorId, @tarih)", conn);
                    ekleCmd.Parameters.AddWithValue("@hastaAdi", hastaAdi);
                    ekleCmd.Parameters.AddWithValue("@hastaSoyadi", hastaSoyadi);
                    ekleCmd.Parameters.AddWithValue("@bransId", bransId);
                    ekleCmd.Parameters.AddWithValue("@doktorId", doktorId);
                    ekleCmd.Parameters.AddWithValue("@tarih", randevuSaati);

                    ekleCmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu baþarýyla kaydedildi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        
    }
}
