namespace ODEV2
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
            btnOdemeYap = new Button();
            PayMethods = new ComboBox();
            textBoxTutar = new TextBox();
            labelSonuc = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(259, 218);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(138, 23);
            btnOdemeYap.TabIndex = 0;
            btnOdemeYap.Text = "Odeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // PayMethods
            // 
            PayMethods.FormattingEnabled = true;
            PayMethods.Items.AddRange(new object[] { "EFT", "Havale", "KrediKarti" });
            PayMethods.Location = new Point(403, 172);
            PayMethods.Name = "PayMethods";
            PayMethods.Size = new Size(121, 23);
            PayMethods.TabIndex = 1;
            PayMethods.SelectedIndexChanged += OdemeYontemleri_SelectedIndexChanged;
            // 
            // textBoxTutar
            // 
            textBoxTutar.Location = new Point(336, 126);
            textBoxTutar.Name = "textBoxTutar";
            textBoxTutar.Size = new Size(100, 23);
            textBoxTutar.TabIndex = 2;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(426, 222);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(40, 15);
            labelSonuc.TabIndex = 3;
            labelSonuc.Text = "Sonuc";
            labelSonuc.Click += labelSonuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 129);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "Fiyat Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 175);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 5;
            label2.Text = "Odeme Yontemi Seciniz :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelSonuc);
            Controls.Add(textBoxTutar);
            Controls.Add(PayMethods);
            Controls.Add(btnOdemeYap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdemeYap;
        private ComboBox PayMethods;
        private TextBox textBoxTutar;
        private Label labelSonuc;
        private Label label1;
        private Label label2;
    }
}
