using E_Kitap.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Kitap
{
    public partial class Kullanıcı_Paneli : Form
    {
        private BookService _bookService;
        private VoteService _voteService;
       
        public Kullanıcı_Paneli()
        {  
            InitializeComponent();
            _bookService = new BookService();
            _voteService = new VoteService();

        }


        void Liste()
        {
            var q = from a in _bookService.GetAll()
                    select new
                    {
                        a.Id,
                        a.Ad,
                        a.Yazar,
                        a.Yayinevi,
                        a.Yayinlanmayili,
                        a.Oy


                    };


        
    dataGridView1.DataSource = q.ToList();




        }
      


        void Liste(string param)
        {

            var q = from a in _bookService.GetAll()                    
                    select new
                    {
                        a.Id,
                        a.Ad,
                        a.Yazar,
                        a.Yayinevi,
                        a.Yayinlanmayili,
                        a.Oy


                   };
           dataGridView1.DataSource = q.Where(x => x.Ad.Contains(param) || x.Yazar.Contains(param) || x.Yayinlanmayili.ToString().Contains(param)).ToList();
                


        }

        private void button1_Click(object sender, EventArgs e)
        {
            En_popüler_kitaplar en_Popüler_Kitaplar = new En_popüler_kitaplar();
            en_Popüler_Kitaplar.Show();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YeniEklenenKitaplar yeniEklenenKitaplar = new YeniEklenenKitaplar();
            yeniEklenenKitaplar.Show();

        }

        private void Kullanıcı_Paneli_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Liste(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            En_iyi_Kitaplar en_İyi_Kitaplar = new En_iyi_Kitaplar();
            en_İyi_Kitaplar.Show();


        }
    }
}
