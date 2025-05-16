namespace HastaRandevuFormu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbBranslar = new ComboBox();
            cmbDoktorlar = new ComboBox();
            cmbTarihler = new ComboBox();
            cmbSaatler = new ComboBox();
            txtHastaAdi = new TextBox();
            txtHastaSoyadi = new TextBox();
            btnRandevuOlustur = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 74);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "HASTA RANDEVU SİSTEMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 122);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Branşlar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 159);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Doktorlar :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 232);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 3;
            label4.Text = "Randevu Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 267);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 4;
            label5.Text = "Randevu Saati :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 329);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Hasta Adı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(268, 364);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 6;
            label7.Text = "Hasta Soyadı :";
            // 
            // cmbBranslar
            // 
            cmbBranslar.FormattingEnabled = true;
            cmbBranslar.Location = new Point(329, 119);
            cmbBranslar.Name = "cmbBranslar";
            cmbBranslar.Size = new Size(121, 23);
            cmbBranslar.TabIndex = 7;
            cmbBranslar.SelectedIndexChanged += cmbBranslar_SelectedIndexChanged;
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(336, 156);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(121, 23);
            cmbDoktorlar.TabIndex = 8;
            cmbDoktorlar.SelectedIndexChanged += cmbDoktorlar_SelectedIndexChanged;
            // 
            // cmbTarihler
            // 
            cmbTarihler.FormattingEnabled = true;
            cmbTarihler.Location = new Point(365, 229);
            cmbTarihler.Name = "cmbTarihler";
            cmbTarihler.Size = new Size(121, 23);
            cmbTarihler.TabIndex = 9;
            cmbTarihler.SelectedIndexChanged += cmbTarihler_SelectedIndexChanged;
            // 
            // cmbSaatler
            // 
            cmbSaatler.FormattingEnabled = true;
            cmbSaatler.Location = new Point(361, 264);
            cmbSaatler.Name = "cmbSaatler";
            cmbSaatler.Size = new Size(121, 23);
            cmbSaatler.TabIndex = 10;
            cmbSaatler.SelectedIndexChanged += cmbSaatler_SelectedIndexChanged;
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.Location = new Point(338, 326);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(119, 23);
            txtHastaAdi.TabIndex = 11;
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Location = new Point(355, 361);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(119, 23);
            txtHastaSoyadi.TabIndex = 12;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(396, 421);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(151, 44);
            btnRandevuOlustur.TabIndex = 13;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 650);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(txtHastaAdi);
            Controls.Add(cmbSaatler);
            Controls.Add(cmbTarihler);
            Controls.Add(cmbDoktorlar);
            Controls.Add(cmbBranslar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbBranslar;
        private ComboBox cmbDoktorlar;
        private ComboBox cmbTarihler;
        private ComboBox cmbSaatler;
        private TextBox txtHastaAdi;
        private TextBox txtHastaSoyadi;
        private Button btnRandevuOlustur;
    }
}
