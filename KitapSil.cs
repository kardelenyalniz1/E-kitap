using E_Kitap.Context;
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
    public partial class KitapSil : Form
    {
       
        private BookService _bookService;
        private ProjeContext _context;
        public KitapSil()
        {
            InitializeComponent();
            _bookService = new BookService();
            _context = new ProjeContext();
        }

        void KitapListele()
        {
            var q = from b in _bookService.GetAll()
                    select new
                    {
                        
                        b.Id,
                        b.Ad,
                        b.Yazar,
                        b.Yayinevi,
                        b.Yayinlanmayili


                    };
            dataGridView1.DataSource = q.ToList();
                
        }

        void KitapListele(string param)
        {
            var q = from b in _bookService.GetAll()
                    select new
                    {
                        b.Id,
                        b.Ad,
                        b.Yazar,
                        b.Yayinevi,
                        b.Yayinlanmayili


                    };
            dataGridView1.DataSource = q.Where(x => x.Id.ToString().Contains(param) || x.Ad.ToString().Contains(param) || x.Yayinevi.ToString().Contains(param) || x.Yayinlanmayili.ToString().Contains(param) || x.Yazar.ToString().Contains(param)).ToList();

        }

        void kitapyoket(int id)
        {
            SqlConnection con = new SqlConnection("Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123" );
            string sql = $"DELETE FROM Books WHERE Id={id}";
            SqlCommand komut = new SqlCommand(sql, con);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            
        }

        private void KitapSil_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KitapListele(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow draw in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(draw.Cells[0].Value);
                kitapyoket(id);
               

            }
          
            KitapListele();
         
        }

        
    }
}
