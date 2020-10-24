namespace E_Kitap
{
    partial class YöneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiPaneli));
            this.kitapeklebuton = new System.Windows.Forms.Button();
            this.kitapsilmebutton = new System.Windows.Forms.Button();
            this.kitaplistelemebutton = new System.Windows.Forms.Button();
            this.kullanıcısilmebutton = new System.Windows.Forms.Button();
            this.kullanıcılistelemebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kitapeklebuton
            // 
            this.kitapeklebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapeklebuton.ForeColor = System.Drawing.Color.Black;
            this.kitapeklebuton.Location = new System.Drawing.Point(44, 197);
            this.kitapeklebuton.Name = "kitapeklebuton";
            this.kitapeklebuton.Size = new System.Drawing.Size(152, 51);
            this.kitapeklebuton.TabIndex = 0;
            this.kitapeklebuton.Text = "Kitap Ekle";
            this.kitapeklebuton.UseVisualStyleBackColor = true;
            this.kitapeklebuton.Click += new System.EventHandler(this.kitapeklebuton_Click);
            // 
            // kitapsilmebutton
            // 
            this.kitapsilmebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapsilmebutton.Location = new System.Drawing.Point(289, 197);
            this.kitapsilmebutton.Name = "kitapsilmebutton";
            this.kitapsilmebutton.Size = new System.Drawing.Size(152, 51);
            this.kitapsilmebutton.TabIndex = 1;
            this.kitapsilmebutton.Text = "Kitap Silme";
            this.kitapsilmebutton.UseVisualStyleBackColor = true;
            this.kitapsilmebutton.Click += new System.EventHandler(this.kitapsilmebutton_Click);
            // 
            // kitaplistelemebutton
            // 
            this.kitaplistelemebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitaplistelemebutton.Location = new System.Drawing.Point(289, 289);
            this.kitaplistelemebutton.Name = "kitaplistelemebutton";
            this.kitaplistelemebutton.Size = new System.Drawing.Size(152, 51);
            this.kitaplistelemebutton.TabIndex = 2;
            this.kitaplistelemebutton.Text = "Mevcut Kitapları Listeleme";
            this.kitaplistelemebutton.UseVisualStyleBackColor = true;
            this.kitaplistelemebutton.Click += new System.EventHandler(this.kitaplistelemebutton_Click);
            // 
            // kullanıcısilmebutton
            // 
            this.kullanıcısilmebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcısilmebutton.Location = new System.Drawing.Point(559, 197);
            this.kullanıcısilmebutton.Name = "kullanıcısilmebutton";
            this.kullanıcısilmebutton.Size = new System.Drawing.Size(152, 51);
            this.kullanıcısilmebutton.TabIndex = 3;
            this.kullanıcısilmebutton.Text = " Kullanıcı Silme";
            this.kullanıcısilmebutton.UseVisualStyleBackColor = true;
            this.kullanıcısilmebutton.Click += new System.EventHandler(this.kullanıcısilmebutton_Click);
            // 
            // kullanıcılistelemebutton
            // 
            this.kullanıcılistelemebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcılistelemebutton.Location = new System.Drawing.Point(559, 289);
            this.kullanıcılistelemebutton.Name = "kullanıcılistelemebutton";
            this.kullanıcılistelemebutton.Size = new System.Drawing.Size(152, 42);
            this.kullanıcılistelemebutton.TabIndex = 4;
            this.kullanıcılistelemebutton.Text = "Kullanıcıları Listeleme";
            this.kullanıcılistelemebutton.UseVisualStyleBackColor = true;
            this.kullanıcılistelemebutton.Click += new System.EventHandler(this.kullanıcılistelemebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(39, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yeni Kitap İşlemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(545, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mevcut Kullanıcılar \r\nÜzerinden İşlemler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(285, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mevcut Kitaplar \r\nÜzerinden İşlemler";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // YöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanıcılistelemebutton);
            this.Controls.Add(this.kullanıcısilmebutton);
            this.Controls.Add(this.kitaplistelemebutton);
            this.Controls.Add(this.kitapsilmebutton);
            this.Controls.Add(this.kitapeklebuton);
            this.Name = "YöneticiPaneli";
            this.Text = "Yönetici Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YöneticiPaneli_FormClosing);
            this.Load += new System.EventHandler(this.YöneticiPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kitapeklebuton;
        private System.Windows.Forms.Button kitapsilmebutton;
        private System.Windows.Forms.Button kitaplistelemebutton;
        private System.Windows.Forms.Button kullanıcısilmebutton;
        private System.Windows.Forms.Button kullanıcılistelemebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}