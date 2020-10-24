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
    public partial class Kullanıcı_Listeleme : Form
    {
        private UserService _userService;

        public Kullanıcı_Listeleme()
        {
            _userService = new UserService();
            InitializeComponent();
        }
        void KullaniciListele()
        {
            var q = from b in _userService.GetAll()
                    select new
                    {
                        b.Kullaniciadi,
                        b.Lokasyon,
                        b.Yas,
                

                    };
            dataGridView1.DataSource = q.ToList();

        }

        private void Kullanıcı_Listeleme_Load(object sender, EventArgs e)
        { 
            KullaniciListele();
        }

        private void Kullanıcı_Listeleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}
