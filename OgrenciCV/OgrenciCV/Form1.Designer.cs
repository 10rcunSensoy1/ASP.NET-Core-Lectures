namespace OgrenciCV
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
            OgrenciAdi = new TextBox();
            OgrenciSoyadi = new TextBox();
            OgrenciBolumu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SonucButton = new Button();
            SonucLabel = new Label();
            SuspendLayout();
            // 
            // OgrenciAdi
            // 
            OgrenciAdi.Location = new Point(306, 92);
            OgrenciAdi.Name = "OgrenciAdi";
            OgrenciAdi.Size = new Size(146, 23);
            OgrenciAdi.TabIndex = 0;
            OgrenciAdi.TextChanged += OgrenciAdi_TextChanged;
            // 
            // OgrenciSoyadi
            // 
            OgrenciSoyadi.Location = new Point(306, 145);
            OgrenciSoyadi.Name = "OgrenciSoyadi";
            OgrenciSoyadi.Size = new Size(146, 23);
            OgrenciSoyadi.TabIndex = 1;
            OgrenciSoyadi.TextChanged += OgrenciSoyadi_TextChanged;
            // 
            // OgrenciBolumu
            // 
            OgrenciBolumu.Location = new Point(306, 198);
            OgrenciBolumu.Name = "OgrenciBolumu";
            OgrenciBolumu.Size = new Size(146, 23);
            OgrenciBolumu.TabIndex = 2;
            OgrenciBolumu.TextChanged += OgrenciBolumu_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 95);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Öğrenci Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 148);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Soyadı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 201);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci Bölümü : ";
            // 
            // SonucButton
            // 
            SonucButton.Location = new Point(197, 251);
            SonucButton.Name = "SonucButton";
            SonucButton.Size = new Size(209, 38);
            SonucButton.TabIndex = 6;
            SonucButton.Text = "Sonucu Getir";
            SonucButton.UseVisualStyleBackColor = true;
            SonucButton.Click += SonucButton_Click;
            // 
            // SonucLabel
            // 
            SonucLabel.AutoSize = true;
            SonucLabel.Location = new Point(197, 321);
            SonucLabel.Name = "SonucLabel";
            SonucLabel.Size = new Size(49, 15);
            SonucLabel.TabIndex = 7;
            SonucLabel.Text = "Sonuc : ";
            SonucLabel.Click += SonucLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SonucLabel);
            Controls.Add(SonucButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OgrenciBolumu);
            Controls.Add(OgrenciSoyadi);
            Controls.Add(OgrenciAdi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OgrenciAdi;
        private TextBox OgrenciSoyadi;
        private TextBox OgrenciBolumu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button SonucButton;
        private Label SonucLabel;
    }
}
