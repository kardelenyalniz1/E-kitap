namespace E_Kitap
{
	partial class GirişYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişYap));
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(348, 114);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(229, 22);
            this.txtsifre.TabIndex = 9;
            this.txtsifre.TextChanged += new System.EventHandler(this.txtsifre_TextChanged);
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(348, 47);
            this.txtkullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(229, 22);
            this.txtkullaniciadi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(679, 60);
            this.btngiris.Margin = new System.Windows.Forms.Padding(4);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(231, 53);
            this.btngiris.TabIndex = 10;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.Btngiris_Click);
            // 
            // GirişYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirişYap";
            this.Text = "Giriş Yap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirişYap_FormClosing);
            this.Load += new System.EventHandler(this.GirişYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtsifre;
		private System.Windows.Forms.TextBox txtkullaniciadi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btngiris;
	}
}