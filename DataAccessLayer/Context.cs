using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MadeoHFTDB;integrated security=True;");
        }

        public DbSet<Admin> Admins { get; set; } //HALLEDİLDİ
        public DbSet<Banner> Banners { get; set; } //HALLEDİLDİ
        public DbSet<Buynow> BuyNow { get; set; } //HALLEDİLDİ
        public DbSet<HomePage> HomePage { get; set; } //HALLEDİLDİ
        public DbSet<Image> Images { get; set; } //HALLEDİLDİ
        public DbSet<Link> Links { get; set; } //HALLEDİLDİ
        public DbSet<Product> Products { get; set; } //HALLEDİLDİ
        public DbSet<Footer> Footer { get; set; } //HALLEDİLDİ
        public DbSet<Technology1> Technology1 { get; set; } //HALLEDİLDİ
        public DbSet<Technology2> Technology2 { get; set; } //HALLEDİLDİ
        public DbSet<Technology3> Technology3 { get; set; } //HALLEDİLDİ
        public DbSet<Form> Form { get; set; } //HALLEDİLDİ
    }
}
