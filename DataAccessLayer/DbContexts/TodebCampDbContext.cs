using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Entities;

namespace DataAccessLayer.DbContexts
{
    public class TodebCampDbContext : DbContext //DbContext sınıfından kalıtım alıyoruz.
    {
        private IConfiguration _configuration; //json dosyaları içindeki ayarlara erişmek için IConfiguration kullanılır.
        public TodebCampDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Address> Addresses { get; set; } //Adress türünde Adresses adında bir DbSet oluşturuyoruz. Burada database'de Adress kısmındaki tabloya karşılık gelen entity'yi tanımlamış olduk.
        public DbSet<Category> Categories { get; set; } //Category türünde Categories adında bir DbSet oluşturuyoruz. 
        public DbSet<Product> Products { get; set; } //Product türünde Products adında bir DbSet oluşturuyoruz.
        public DbSet<Supplier> Suppliers { get; set; } //Supplier türünde Suppliers adında bir DbSet oluşturuyoruz.
        public DbSet<Customer> Customers { get; set; } //Customer türünde Customers adında bir DbSet oluşturuyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //OnConfiguring metodunu override ediyoruz. Burada hangi database'i kullanacağımızı ayarlıyoruz. Bu bilgileri yazmadan önce NuGet Manager'den ilgili database'i indirmemiz gerek.
        {
            //base.OnConfiguring(optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TodebCamp;User Id=postgres;Password=12345;")); //Npgsql kullanıcısının bilgileriyle database'e bağlanıyoruz.
            var connectionString = _configuration.GetConnectionString("MsComm"); //Configuration'daki database bağlantısını connectionString nesnesine eşitliyoruz.
            base.OnConfiguring(optionsBuilder.UseNpgsql(connectionString)); //database bağlantısını burada yapıyoruz. Magicstring ifadeyi de configuration içinden almış oluyoruz.
        }
    }
}
