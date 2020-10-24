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
    public partial class Kullanıcı_silme : Form
    {
        private UserService _userService;
        private ProjeContext _context;
        public Kullanıcı_silme()
        {
            _userService = new UserService();
            _context = new ProjeContext();

            InitializeComponent();
        }
        void KullaniciListele()
        {
            var q = from b in _userService.GetAll()
                    select new
                    {
                        b.Id,
                        b.Kullaniciadi,
                        b.Lokasyon,
                        b.Yas,


                    };
            dataGridView1.DataSource = q.ToList();

        }
        void KullaniciListele1(string param)
        {
            var q = from b in _userService.GetAll()
                    select new
                    {   b.Id,
                        b.Kullaniciadi,
                        b.Lokasyon,
                        b.Yas,


                    };
            dataGridView1.DataSource = q.Where(x => x.Id.ToString().Contains(param) || x.Kullaniciadi.ToString().Contains(param) || x.Lokasyon.ToString().Contains(param) || x.Yas.ToString().Contains(param)).ToList();

        }

        void kullaniciyoket(int id)
        {
            SqlConnection con = new SqlConnection("Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123" );
            string sql = $"DELETE FROM Users WHERE Id={id}";
            SqlCommand komut = new SqlCommand(sql, con);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();

        }


        private void Kullanıcı_silme_Load(object sender, EventArgs e)
        {
            KullaniciListele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            KullaniciListele1(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow draw in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(draw.Cells[0].Value);
                kullaniciyoket(id);


            }
            KullaniciListele();
        }
    }
}
