using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace ef02.Model
{
    public class ShopContext : DbContext
    {
        protected string connect_str = @"Data Source=localhost,1433;
                                         Initial Catalog=shopdata;
                                         User ID=SA;Password=Password123";
        public DbSet<Product> products {set; get;}      // bảng Products
        public DbSet<Category> categories {set; get;}   // bảng Category

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Tạo ILoggerFactory
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

            optionsBuilder.UseSqlServer(connect_str)            // thiết lập làm việc với SqlServer
                        .UseLoggerFactory(loggerFactory)      // thiết lập logging
                        .UseLazyLoadingProxies() ;
        }

        // Tạo database
        public async Task CreateDatabase()
        {
            String databasename = Database.GetDbConnection().Database;

            Console.WriteLine("Tạo " + databasename);
            bool result = await Database.EnsureCreatedAsync();
            string resultstring = result ? "tạo  thành  công" : "đã có trước đó";
            Console.WriteLine($"CSDL {databasename} : {resultstring}");
        }

        // Xóa Database
        public async Task DeleteDatabase()
        {
            String databasename = Database.GetDbConnection().Database;
            Console.Write($"Có chắc chắn xóa {databasename} (y) ? ");
             string input = Console.ReadLine();

            // // Hỏi lại cho chắc
            if (input.ToLower() == "y")
            {
                bool deleted = await Database.EnsureDeletedAsync();
                string deletionInfo = deleted ? "đã xóa" : "không xóa được";
                Console.WriteLine($"{databasename} {deletionInfo}");
            }
        }

        // Lấy một Product từ DB theo ProductID
        public async Task<Product> FindProduct(int id) {
            var p =  await (from c  in products where c.ProductId == id select c).FirstOrDefaultAsync(); 
            await  Entry(p)                    // lấy DbEntityEntry liên quan đến p
                .Reference(x => x.Category) // lấy tham chiếu, liên quan đến thuộc tính Category
                .LoadAsync();               // nạp thuộc tính từ DB
            return  p;
        }
        
    }
}