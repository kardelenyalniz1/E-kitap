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
    public partial class En_iyi_Kitaplar : Form
    {
        BookService _bookService;
        VoteService VoteService;

        public En_iyi_Kitaplar()
        {
            
            InitializeComponent();
            VoteService = new VoteService();
            _bookService = new BookService();
        }
        void EnİyiKitapListe()
        {

            SqlConnection con = new SqlConnection("Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123");
            con.Open();
            string sql = $"Select top 10 Ad,Yazar,YayinlanmaYili,Yayinevi,Oy from Books order by Oy DESC";
            SqlCommand komut = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();




        }


        private void En_iyi_Kitaplar_Load_1(object sender, EventArgs e)
        {
            EnİyiKitapListe();
        }
    }
}
