namespace ODEV1
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
            listBox1 = new ListBox();
            btnTara = new Button();
            label1 = new Label();
            textYol = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(488, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 139);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnTara
            // 
            btnTara.Location = new Point(169, 194);
            btnTara.Name = "btnTara";
            btnTara.Size = new Size(123, 44);
            btnTara.TabIndex = 1;
            btnTara.Text = "Dosyalari Tara";
            btnTara.UseVisualStyleBackColor = true;
            btnTara.Click += btnTara_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 114);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Dosya Yolunu Girin";
            label1.Click += label1_Click;
            // 
            // textYol
            // 
            textYol.Location = new Point(169, 148);
            textYol.Name = "textYol";
            textYol.Size = new Size(249, 23);
            textYol.TabIndex = 3;
            textYol.TextChanged += textYol_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textYol);
            Controls.Add(label1);
            Controls.Add(btnTara);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnTara;
        private Label label1;
        private TextBox textYol;
    }
}
