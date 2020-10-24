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
    public partial class En_popüler_kitaplar : Form
    {
        BookService _bookService;
        public En_popüler_kitaplar()
        {
            _bookService = new BookService();
            InitializeComponent();
        }
        
        void Listele()
        {

            SqlConnection con = new SqlConnection("Server =.; Database = EternalOdev4; uid = sa; pwd = 123");
            con.Open();
            //Select KitapID, Id, Ad, Yazar, Count (KitapID) as Oy Adeti from Votes Join Books on(KitapID = Id) Group By KitapID having Count(KitapID) > 1 order By Oy Adeti DESC

            string sql = $"select top 10 b.Ad,Count(v.KitapID) as 'Oy Adeti' from Votes as v join Books as b on v.KitapID = b.Id Group By b.Ad order by 2 DESC";

            SqlCommand komut = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }
     private void En_popüler_kitaplar_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
