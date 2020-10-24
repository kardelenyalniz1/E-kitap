using E_Kitap.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;0
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Kitap
{
    public partial class YeniEklenenKitaplar : Form
    {
        private BookService _bookService;
        public YeniEklenenKitaplar()
        {
            _bookService = new BookService();

            InitializeComponent();
        }
        void YeniKitapListele()
        {

            
            SqlConnection con = new SqlConnection("Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123");
            con.Open();
            string sql = $"Select top 5 Ad,Yazar,YayinEvi,Yayinlanmayili from Books order by Id DESC";
            SqlCommand komut = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;      
            
            con.Close();


        }

        


        private void YeniEklenenKitaplar_Load(object sender, EventArgs e)
        {
            YeniKitapListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
