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
            DeSerializebutton = new Button();
            listboxURUNLER = new ListBox();
            SuspendLayout();
            // 
            // DeSerializebutton
            // 
            DeSerializebutton.Location = new Point(255, 133);
            DeSerializebutton.Name = "DeSerializebutton";
            DeSerializebutton.Size = new Size(91, 23);
            DeSerializebutton.TabIndex = 0;
            DeSerializebutton.Text = "DeSerialize Et";
            DeSerializebutton.UseVisualStyleBackColor = true;
            DeSerializebutton.Click += DeSerializebutton_Click;
            // 
            // listboxURUNLER
            // 
            listboxURUNLER.FormattingEnabled = true;
            listboxURUNLER.ItemHeight = 15;
            listboxURUNLER.Location = new Point(255, 177);
            listboxURUNLER.Name = "listboxURUNLER";
            listboxURUNLER.Size = new Size(331, 214);
            listboxURUNLER.TabIndex = 1;
            listboxURUNLER.SelectedIndexChanged += listboxURUNLER_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listboxURUNLER);
            Controls.Add(DeSerializebutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button DeSerializebutton;
        private ListBox listboxURUNLER;
    }
}
