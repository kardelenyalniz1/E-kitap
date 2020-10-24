using E_Kitap.Context;
using E_Kitap.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Kitap

{
	public partial class GirişYap : Form
	{
		private UserService _userService;
        string username;
        int kullanicioy;
        bool adminkontrol;
		bool idsifrekontrol;
		public GirişYap()
		{
			InitializeComponent();
			_userService = new UserService();
		
		}

		public bool Idsifrekontrol(string kullaniciadi,string sifre)
		{

			var user = _userService.GetByDefault(x => x.Kullaniciadi == kullaniciadi && x.Sifre == sifre);
			if (user != null)
			{
				idsifrekontrol = true;
			}
			else
			{
				idsifrekontrol = false;
			}

			return idsifrekontrol;
		}


        public bool AdminKontrol(string kullaniciadi)
        {
            var user = _userService.GetByDefault(x => x.Kullaniciadi ==kullaniciadi && x.Admin==true);
            if(user != null)
            {
                adminkontrol = true;
                

            }
            else
            {
                adminkontrol = false;
            }
            return adminkontrol;
        }

        public int Kullanicigereklioy(string kullaniciadi)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;
            SqlDataReader reader;

            connetionString = "Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123" ;
            sql = $"Select gereklioylama from Users where Kullaniciadi='{kullaniciadi}'";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                kullanicioy = reader.GetInt32(0);

            }
            reader.Close();
            cmd.Dispose();
            cnn.Close();
            return kullanicioy;

        }


        private void GirişYap_Load(object sender, EventArgs e)
		{

		}

		private void GirişYap_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void Btngiris_Click(object sender, EventArgs e)
		{                
            idsifrekontrol = false;
			Idsifrekontrol(txtkullaniciadi.Text, txtsifre.Text);
			if (idsifrekontrol)
			{
                AdminKontrol(txtkullaniciadi.Text);
                if (adminkontrol == true)
                {
                    YöneticiPaneli yöneticiPaneli = new YöneticiPaneli();
                    yöneticiPaneli.Show();
                    this.Hide();

                }
                else
                {
                    kullanicioy = 0;
                    Kullanicigereklioy(txtkullaniciadi.Text);
                    if (kullanicioy == 10)
                    {
                        Kullanıcı_Paneli kp = new Kullanıcı_Paneli();
                        kp.Show();
                        this.Hide();
                    }
                    else
                    {
                        username = "";
                        username = txtkullaniciadi.Text;

                        Yeniüye frm2 = new Yeniüye();
                        frm2.username = username;
                        frm2.Show();
                        frm2.Show();
                        this.Hide();
                    }
                }
                
                
                
			}
			else
			{
				MessageBox.Show("Kullanıcı adı veya şifre yanlıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtkullaniciadi.Text = txtsifre.Text = "";
			}
		}

        
        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
