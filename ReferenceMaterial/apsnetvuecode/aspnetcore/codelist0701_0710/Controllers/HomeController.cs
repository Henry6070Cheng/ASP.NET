using codelist0701.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System.Buffers;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace codelist0701.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArrayPool<byte> _arrayPool;
        private readonly IDataService _dataService;
        private readonly IMemoryCache _memoryCache;
        private readonly IDistributedCache _distributedCache;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMemoryCache memoryCache, IDistributedCache distributedCache, IDataService dataService, ArrayPool<byte> arrayPool)
        {
            _logger = logger;
            _memoryCache = memoryCache;
            _distributedCache = distributedCache;
            _dataService = dataService;
            _arrayPool = arrayPool;
        }

        public IActionResult Index()
        {
            return View();
        }

        //代码清单7-1
        public IActionResult MemoryCache()
        {
            string cachedData = _memoryCache.Get<string>("cachedData");

            if (cachedData == null)
            {
                // 如果缓存中没有数据，则执行计算或查询操作
                cachedData = ExpensiveOperation();

                // 将结果存储在缓存中，有效期为 1 小时
                _memoryCache.Set("cachedData", cachedData, TimeSpan.FromHours(1));
            }

            return View();
        }

        //代码清单7-2
        public IActionResult DistributedCache()
        {
            byte[] cachedData = _distributedCache.Get("cachedData");

            if (cachedData == null)
            {
                // 如果缓存中没有数据，则执行计算或查询操作
                string expensiveData = ExpensiveOperation();
                cachedData = Encoding.UTF8.GetBytes(expensiveData);

                // 将结果存储在分布式缓存中，有效期为 1 小时
                _distributedCache.Set("cachedData", cachedData, new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1)
                });
            }
            return View();
        }

        //代码清单7-3
        [ResponseCache(Duration = 3600)] //缓存响应1小时
        public IActionResult ResponseCache()
        {
            return View();
        }


        //代码清单7-4
        public async Task<IActionResult> GetDataAsync()
        {
            // 异步调用数据服务获取数据
            var data = await _dataService.GetDataAsync();

            // 执行其他操作
            // ...

            return View();
        }

        //代码清单7-5
        public IActionResult GetLongRunningOperation()
        {
            var tasks = new List<Task<int>>();
            var result = new int[5];

            // 创建并行任务
            for (int i = 0; i < 5; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    // 执行耗时操作并返回结果
                    return LongRunningOperation();
                }));
            }

            // 等待所有任务完成
            Task.WaitAll(tasks.ToArray());

            // 获取任务的结果
            for (int i = 0; i < 5; i++)
            {
                result[i] = tasks[i].Result;
            }

            return View(result);
        }

        //代码清单7-6
        public async Task<IActionResult> GetMuchDataAsync()
        {
            var tasks = new List<Task<string>>();
            var results = new List<string>();

            // 并行发起多个异步数据获取任务
            for (int i = 0; i < 5; i++)
            {
                tasks.Add(GetSingleDataAsync());
            }

            // 等待所有任务完成
            while (tasks.Count > 0)
            {
                var completedTask = await Task.WhenAny(tasks);
                tasks.Remove(completedTask);
                results.Add(await completedTask);
            }

            return View(results);
        }

        //代码清单7-7
        public IActionResult GetUsing()
        {
            var connectionString = "Data Source=.;Initial Catalog=MyDb;User Id=sa;Password=fuqing68+++;Trusted_Connection=True;Encrypt=false;";
            using (var connection = new SqlConnection(connectionString))
            {
                // 使用数据库连接执行操作
                // ...
            }

            // connection 对象在 using 语句块结束后自动释放
            return View();
        }

        //代码清单7-8
        public IActionResult GetStringBuilder()
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                // 避免在循环中创建 StringBuilder 对象
                stringBuilder.Append(i);
            }

            string result = stringBuilder.ToString();

            return View();
        }

        //代码清单7-9
        public IActionResult GetArrayPool()
        {
            byte[] buffer = _arrayPool.Rent(1024); // 从对象池中获取一个数组

            // 使用 buffer 执行操作
            // ...

            _arrayPool.Return(buffer); // 将数组返回对象池

            return View();
        }


        private async Task<string> GetSingleDataAsync()
        {
            // 异步调用数据服务获取数据
            var data = await _dataService.GetDataAsync();

            // 执行其他异步操作
            // ...

            return data;
        }

        private int LongRunningOperation()
        {
            // 执行耗时操作
            // ...
            Thread.Sleep(5 * 1000);
            return 5;
        }

        private string ExpensiveOperation()
        {
            // 执行昂贵的计算或查询操作
            Thread.Sleep(5 * 1000);
            return "5";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}