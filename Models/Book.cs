using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Kitap.Models
{
    public class Book : BaseEntity
    {
        public string Ad { get; set; }

        public string Yazar { get; set; }

        public string Yayinlanmayili { get; set; }

        public string Yayinevi { get; set; }

        public string URL { get; set; }

        public int Oy { get; set; }

       

		public Book()
		{
			this.Oy = 0;

		}


	}
}
