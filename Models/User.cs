using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Kitap.Models
{
	public class User : BaseEntity
	{
		public string Kullaniciadi { get; set; }
		public string Sifre { get; set; }

		public string Lokasyon { get; set; }

		public string Yas  { get; set; }

        public int gereklioylama { get; set; }

        public bool Admin { get; set; }
    }
}
