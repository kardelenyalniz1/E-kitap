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
    public partial class YöneticiPaneli : Form
    {
        public YöneticiPaneli()
        {
            InitializeComponent();
        }

       

        private void kitapeklebuton_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
            
                }

        private void kitaplistelemebutton_Click(object sender, EventArgs e)
        {
            KitapListele kitapListele = new KitapListele();
            kitapListele.Show();
         
        }

        private void kitapsilmebutton_Click(object sender, EventArgs e)
        {
            KitapSil kitapsil = new KitapSil();
            kitapsil.Show();
           
        }

        private void kullanıcılistelemebutton_Click(object sender, EventArgs e)
        {
            Kullanıcı_Listeleme kullanıcı_Listeleme = new Kullanıcı_Listeleme();
            kullanıcı_Listeleme.Show();
            

        }

        private void YöneticiPaneli_Load(object sender, EventArgs e)
        {

        }

        private void YöneticiPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void kullanıcısilmebutton_Click(object sender, EventArgs e)
        {
            Kullanıcı_silme kullanıcı_Silme = new Kullanıcı_silme();
            kullanıcı_Silme.Show();
        }
    }
 
}
