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
    public partial class KitapListele : Form
    {
        private BookService _bookService;

        public KitapListele()
        {
            InitializeComponent();

            _bookService = new BookService();
        }
        void KitapListele1()
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

        private void KitapListele_Load(object sender, EventArgs e)
        {
            KitapListele1();

        }

        private void KitapListele_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
