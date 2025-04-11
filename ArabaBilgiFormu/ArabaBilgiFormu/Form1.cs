namespace ArabaBilgiFormu
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BligileriGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marka: " + textBoxMarka.Text + "\nModel: " + textBoxModel.Text + "\nRenk: " + textBoxRenk.Text + "\nKapi sayisi: " + textBoxKapi.Text + "\nPencere sayisi: "+ textBoxPencere.Text + "\nYakit/100km: "+ textBoxYakit.Text);

        }
    }
}
