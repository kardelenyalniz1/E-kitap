namespace E_Kitap
{
    partial class Kayıt_ol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt_ol));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtlokasyon = new System.Windows.Forms.TextBox();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.kayıtolbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(135, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(225, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(170, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lokasyon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(236, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yaş :";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(330, 57);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(249, 22);
            this.txtkullaniciadi.TabIndex = 5;
            this.txtkullaniciadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(330, 117);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(249, 22);
            this.txtsifre.TabIndex = 6;
            // 
            // txtlokasyon
            // 
            this.txtlokasyon.Location = new System.Drawing.Point(330, 170);
            this.txtlokasyon.Name = "txtlokasyon";
            this.txtlokasyon.Size = new System.Drawing.Size(249, 22);
            this.txtlokasyon.TabIndex = 7;
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(330, 215);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(249, 22);
            this.txtyas.TabIndex = 8;
            // 
            // kayıtolbutton
            // 
            this.kayıtolbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtolbutton.Location = new System.Drawing.Point(330, 273);
            this.kayıtolbutton.Name = "kayıtolbutton";
            this.kayıtolbutton.Size = new System.Drawing.Size(203, 63);
            this.kayıtolbutton.TabIndex = 9;
            this.kayıtolbutton.Text = "KAYDOL";
            this.kayıtolbutton.UseVisualStyleBackColor = true;
            this.kayıtolbutton.Click += new System.EventHandler(this.kayıtolbutton_Click);
            // 
            // Kayıt_ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kayıtolbutton);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.txtlokasyon);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kayıt_ol";
            this.Text = "Kayıt_ol";
            this.Load += new System.EventHandler(this.Kayıt_ol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtlokasyon;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Button kayıtolbutton;
    }
}