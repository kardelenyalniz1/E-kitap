using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Kitap.Models
{
	public class Vote : BaseEntity
	{
		public int KullaniciID { get; set; }

		public int KitapID { get; set; }

        public int Oypuani { get; set; }


    }
}
