using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace codelist0302_0320.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //代码清单3-3
        [HttpGet("0303")]
        public void Get0303()
        {
            using (var context = new MyDbContext())
            {
                var products = context.Products.ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"产品名称：{product.Name}，价格：{product.Price}");
                }
            }
        }

        //代码清单3-11
        [HttpGet("0311")]
        public void Get0311()
        {
            using (var context = new MyDbContext())
            {
                var products = context.Products
                    .Where(p => p.Price > 10)
                    .OrderBy(p => p.Name)
                    .ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"产品名称：{product.Name}，价格：{product.Price}");
                }
            }
        }

        //代码清单3-12
        [HttpGet("0312")]
        public void Get0312()
        {
            using (var context = new MyDbContext())
            {
                var totalPrice = context.Products.Sum(p => p.Price);
                var averagePrice = context.Products.Average(p => p.Price);
                var productCount = context.Products.Count();

                Console.WriteLine($"总价值：{totalPrice}");
                Console.WriteLine($"平均价格：{averagePrice}");
                Console.WriteLine($"产品数量：{productCount}");
            }
        }

        //代码清单3-12
        [HttpGet("0312-1")]
        public void Get03121()
        {
            using (var context = new MyDbContext())
            {
                var products = context.Products
                    .Include(p => p.Category)
                    .Where(p => p.Category.Name == "电子产品")
                    .ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"产品名称：{product.Name}，类别：{product.Category.Name}");
                }
            }
        }

        //代码清单3-13
        [HttpGet("0313")]
        public void Get0313()
        {
            using (var context = new MyDbContext())
            {
                var pageSize = 10;
                var pageNumber = 1;
                var products = context.Products
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"产品名称：{product.Name}，价格：{product.Price}");
                }
            }
        }

        //代码清单3-14
        [HttpPost("0314")]
        public void Post0314()
        {
            using (var context = new MyDbContext())
            {
                var product = new Product
                {
                    Name = "新产品",
                    Price = 99.99m
                };

                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        //代码清单3-15
        [HttpPost("0315")]
        public void Post0315()
        {
            using (var context = new MyDbContext())
            {
                var product = context.Products.FirstOrDefault(p => p.Id == 1);
                if (product != null)
                {
                    product.Price = 129.99m;
                    context.Products.Update(product);
                    context.SaveChanges();
                }
            }
        }

        //代码清单3-16
        [HttpPost("0316")]
        public void Post0316()
        {
            using (var context = new MyDbContext())
            {
                var product = context.Products.FirstOrDefault(p => p.Id == 1);
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
            }
        }

        //代码清单3-17
        [HttpPost("0317")]
        public void Post0317()
        {
            using (var context = new MyDbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var product = new Product
                        {
                            Name = "新产品",
                            Price = 99.99m
                        };

                        // 执行数据库操作
                        context.Products.Add(product);
                        context.SaveChanges();

                        var order = context.Orders.FirstOrDefault(p => p.Id == 1);
                        if (order == null)
                        {
                            throw new Exception("订单不存在！");
                        }

                        // 执行其他数据库操作
                        context.Orders.Remove(order);
                        context.SaveChanges();

                        // 提交事务
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        // 回滚事务
                        transaction.Rollback();
                    }
                }
            }
        }

        //代码清单3-18
        [HttpPost("0318")]
        public void Post0318()
        {
            using (var context = new MyDbContext())
            {
                var product = context.Products.FirstOrDefault(p => p.Id == 3);
                if (product != null)
                {
                    product.Price = 129.99m;
                    context.SaveChanges();
                }
            }
        }

        //代码清单3-19
        [HttpPost("0319")]
        public void Post0319()
        {
            using (var context = new MyDbContext())
            {
                var product = new Product
                {
                    Name = "新产品",
                    Price = 99.99m
                };

                context.Entry(product).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        //代码清单3-20
        [HttpPost("0320")]
        public void Post0320()
        {
            using (var context = new MyDbContext())
            {
                var product = context.Products.FirstOrDefault(p => p.Id == 3);
                if (product != null)
                {
                    product.Price = 139.99m;

                    // 取消更改
                    context.Entry(product).State = EntityState.Unchanged;

                    context.SaveChanges();
                }
            }
        }

    }
}
