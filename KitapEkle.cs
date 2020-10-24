using E_Kitap.Models;
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
    public partial class KitapEkle : Form
    {
        private BookService _bookService;

        public KitapEkle()
        {
            InitializeComponent();
            _bookService = new BookService();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Ad = txtkitapadi.Text;
            book.URL = txturl.Text;
            book.Yayinevi = txtyayinevi.Text;
            book.Yayinlanmayili = txtyayinlanmayil.Text;
            book.Yazar = txtyazar.Text;

            _bookService.Add(book);
            bool result = _bookService.Save()> 0;

            if (result)
            {
                MessageBox.Show("Eklendi");
                txtkitapadi.Text = txturl.Text = txtyayinevi.Text = txtyayinlanmayil.Text = txtyazar.Text = "";
            }
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
