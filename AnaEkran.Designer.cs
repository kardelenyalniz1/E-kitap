namespace E_Kitap
{
	partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.btnkayitol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkayitol
            // 
            this.btnkayitol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkayitol.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkayitol.Location = new System.Drawing.Point(263, 56);
            this.btnkayitol.Margin = new System.Windows.Forms.Padding(4);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(436, 113);
            this.btnkayitol.TabIndex = 0;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = false;
            this.btnkayitol.Click += new System.EventHandler(this.Btnkayitol_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(436, 113);
            this.button1.TabIndex = 1;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnkayitol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaEkran";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnkayitol;
		private System.Windows.Forms.Button button1;
	}
}