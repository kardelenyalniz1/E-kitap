using E_Kitap.Models;
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
    public partial class Kayıt_ol : Form
    {
        
		private UserService _userService;
        bool kullanicivarmi = false;


        public Kayıt_ol()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        public bool Kullanicivarmi(string kullaniciadi)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;
            SqlDataReader reader;

            connetionString = "Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123";
            sql = $"Select Id from Users where Kullaniciadi='{kullaniciadi}'";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cmd = new SqlCommand(sql, cnn);

            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetGuid(0);
                    kullanicivarmi = true;
                    reader.Close();
                    cmd.Dispose();
                    cnn.Close();
                    break;



                }
            }
            catch (Exception)
            {

                kullanicivarmi = false;
            }
            return kullanicivarmi;

        }
    



        private void Kayıt_ol_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kayıtolbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtkullaniciadi.Text.Trim()) || string.IsNullOrEmpty(txtlokasyon.Text.Trim()) || string.IsNullOrEmpty(txtsifre.Text.Trim()) || string.IsNullOrEmpty(txtyas.Text.Trim()))
            {
                MessageBox.Show("Boşlukları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kullanicivarmi = false;
                Kullanicivarmi(txtkullaniciadi.Text);
                if (kullanicivarmi == true)
                {
                    MessageBox.Show("Kullanıcı adı mevcuttur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtkullaniciadi.Text = txtlokasyon.Text = txtsifre.Text = txtyas.Text = "";
                }
                else
                {
                    User user = new User();
                    user.Kullaniciadi = txtkullaniciadi.Text;
                    user.Sifre = txtsifre.Text;
                    user.Lokasyon = txtlokasyon.Text;
                    user.Yas = txtyas.Text;

                    try
                    {
                        _userService.Add(user);
                        _userService.Save();

                        MessageBox.Show("Başarıyla Kayıt Olundu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AnaEkran anaekran = new AnaEkran();
                        anaekran.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bir hata meydana geldi.Hata--->" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
