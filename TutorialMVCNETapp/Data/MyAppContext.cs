

using Microsoft.EntityFrameworkCore;
using TutorialMVCNETapp.Models;

namespace TutorialMVCNETapp.Data
{
    public class MyAppContext: DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) 
        {
            // Constructor
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 5, Name = "Speakers", Price =18.3 ,SerialNumberId=10}
                );
            modelBuilder.Entity<SerialNumber>().HasData(
                new SerialNumber { Id = 10, Name = "SP 350", ItemId = 5 }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Input Devices"},
                new Category { Id = 2, Name = "Output Devices" }
                );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<SerialNumber> SerialNumbers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
