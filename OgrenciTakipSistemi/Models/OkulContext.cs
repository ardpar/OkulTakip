using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Models
{
    public class OkulContext:DbContext
    {

        public OkulContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=EFCore-SchoolDB;Trusted_Connection=True");
        }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Klup> Klupler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
    }
}
