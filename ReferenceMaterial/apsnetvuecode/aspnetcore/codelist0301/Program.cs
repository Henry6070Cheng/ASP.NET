// 引入所需命名空间
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

// 定义实体类
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

// 定义上下文类
public class MyDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyDb;User Id=sa;Password=fuqing68+++;Trusted_Connection=True;Encrypt=false;");
    }
}

// 使用上下文进行数据访问
public class Program
{
    public static void Main()
    {
        using (var context = new MyDbContext())
        {
            // 查询数据
            var products = context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"产品名称：{product.Name}，价格：{product.Price}");
            }

            // 插入数据
            var newProduct = new Product { Name = "新产品", Price = 10.99m };
            context.Products.Add(newProduct);
            context.SaveChanges();

            Console.ReadKey();
        }
    }
}
