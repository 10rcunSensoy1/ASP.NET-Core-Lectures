namespace ArabaBilgiFormu
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
            Labelmarka = new Label();
            textBoxMarka = new TextBox();
            Labelmodel = new Label();
            textBoxModel = new TextBox();
            Labelrenk = new Label();
            textBoxRenk = new TextBox();
            textBoxKapi = new TextBox();
            textBoxPencere = new TextBox();
            textBoxYakit = new TextBox();
            Labelkapisayisi = new Label();
            Labelpenceresayisi = new Label();
            Labelyakit = new Label();
            BligileriGoster = new Button();
            SuspendLayout();
            // 
            // Labelmarka
            // 
            Labelmarka.AutoSize = true;
            Labelmarka.Location = new Point(292, 135);
            Labelmarka.Name = "Labelmarka";
            Labelmarka.Size = new Size(40, 15);
            Labelmarka.TabIndex = 0;
            Labelmarka.Text = "Marka";
            Labelmarka.Click += label1_Click;
            // 
            // textBoxMarka
            // 
            textBoxMarka.Location = new Point(377, 132);
            textBoxMarka.Name = "textBoxMarka";
            textBoxMarka.Size = new Size(100, 23);
            textBoxMarka.TabIndex = 1;
            textBoxMarka.TextChanged += textBox1_TextChanged;
            // 
            // Labelmodel
            // 
            Labelmodel.AutoSize = true;
            Labelmodel.Location = new Point(291, 172);
            Labelmodel.Name = "Labelmodel";
            Labelmodel.Size = new Size(41, 15);
            Labelmodel.TabIndex = 2;
            Labelmodel.Text = "Model";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(377, 169);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 3;
            // 
            // Labelrenk
            // 
            Labelrenk.AutoSize = true;
            Labelrenk.Location = new Point(291, 210);
            Labelrenk.Name = "Labelrenk";
            Labelrenk.Size = new Size(33, 15);
            Labelrenk.TabIndex = 4;
            Labelrenk.Text = "Renk";
            // 
            // textBoxRenk
            // 
            textBoxRenk.Location = new Point(377, 207);
            textBoxRenk.Name = "textBoxRenk";
            textBoxRenk.Size = new Size(100, 23);
            textBoxRenk.TabIndex = 5;
            // 
            // textBoxKapi
            // 
            textBoxKapi.Location = new Point(377, 246);
            textBoxKapi.Name = "textBoxKapi";
            textBoxKapi.Size = new Size(100, 23);
            textBoxKapi.TabIndex = 6;
            // 
            // textBoxPencere
            // 
            textBoxPencere.Location = new Point(377, 284);
            textBoxPencere.Name = "textBoxPencere";
            textBoxPencere.Size = new Size(100, 23);
            textBoxPencere.TabIndex = 7;
            // 
            // textBoxYakit
            // 
            textBoxYakit.Location = new Point(377, 323);
            textBoxYakit.Name = "textBoxYakit";
            textBoxYakit.Size = new Size(100, 23);
            textBoxYakit.TabIndex = 8;
            // 
            // Labelkapisayisi
            // 
            Labelkapisayisi.AutoSize = true;
            Labelkapisayisi.Location = new Point(291, 249);
            Labelkapisayisi.Name = "Labelkapisayisi";
            Labelkapisayisi.Size = new Size(61, 15);
            Labelkapisayisi.TabIndex = 9;
            Labelkapisayisi.Text = "Kapi sayisi";
            // 
            // Labelpenceresayisi
            // 
            Labelpenceresayisi.AutoSize = true;
            Labelpenceresayisi.Location = new Point(291, 287);
            Labelpenceresayisi.Name = "Labelpenceresayisi";
            Labelpenceresayisi.Size = new Size(80, 15);
            Labelpenceresayisi.TabIndex = 10;
            Labelpenceresayisi.Text = "Pencere sayisi";
            // 
            // Labelyakit
            // 
            Labelyakit.AutoSize = true;
            Labelyakit.Location = new Point(291, 326);
            Labelyakit.Name = "Labelyakit";
            Labelyakit.Size = new Size(72, 15);
            Labelyakit.TabIndex = 11;
            Labelyakit.Text = "Yakit/100km";
            // 
            // BligileriGoster
            // 
            BligileriGoster.Location = new Point(471, 398);
            BligileriGoster.Name = "BligileriGoster";
            BligileriGoster.Size = new Size(108, 38);
            BligileriGoster.TabIndex = 12;
            BligileriGoster.Text = "Bilgileri Goster";
            BligileriGoster.UseVisualStyleBackColor = true;
            BligileriGoster.Click += BligileriGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 623);
            Controls.Add(BligileriGoster);
            Controls.Add(Labelyakit);
            Controls.Add(Labelpenceresayisi);
            Controls.Add(Labelkapisayisi);
            Controls.Add(textBoxYakit);
            Controls.Add(textBoxPencere);
            Controls.Add(textBoxKapi);
            Controls.Add(textBoxRenk);
            Controls.Add(Labelrenk);
            Controls.Add(textBoxModel);
            Controls.Add(Labelmodel);
            Controls.Add(textBoxMarka);
            Controls.Add(Labelmarka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Labelmarka;
        private TextBox textBoxMarka;
        private Label Labelmodel;
        private TextBox textBoxModel;
        private Label Labelrenk;
        private TextBox textBoxRenk;
        private TextBox textBoxKapi;
        private TextBox textBoxPencere;
        private TextBox textBoxYakit;
        private Label Labelkapisayisi;
        private Label Labelpenceresayisi;
        private Label Labelyakit;
        private Button BligileriGoster;
    }
}
