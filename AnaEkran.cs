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
	public partial class AnaEkran : Form
	{
		public AnaEkran()
		{
			InitializeComponent();
		}

		private void AnaEkran_Load(object sender, EventArgs e)
		{

		}

		private void Btnkayitol_Click(object sender, EventArgs e)
		{
            Kayıt_ol frm = new Kayıt_ol();
			frm.Show();
            this.Hide();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Form frm = new GirişYap();
			frm.Show();
			this.Hide();
		}
	}
}
