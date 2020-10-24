using E_Kitap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Kitap.Context
{
	public class ProjeContext : DbContext
	{
		public ProjeContext()
		{
			Database.Connection.ConnectionString = "Server=localhost; Database=EternalOdev4; uid=sa; pwd=123;";

		}

		public virtual DbSet<Book> Books { get; set; }

		public virtual DbSet<User> Users { get; set; }

		public virtual DbSet<Vote> Votes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(p => p.Oy).IsOptional();
           

        }

    }
}
