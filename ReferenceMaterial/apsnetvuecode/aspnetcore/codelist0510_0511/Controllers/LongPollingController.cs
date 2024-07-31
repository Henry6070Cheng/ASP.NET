using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

namespace lesson05_4.Controllers;

// 长轮询控制器
public class LongPollingController : ControllerBase
{
    // 假设这里有一个数据源，用于存储实时更新的数据
    private static readonly ConcurrentQueue<string> dataQueue = new ConcurrentQueue<string>();

    // 长轮询请求处理
    [HttpGet]
    public async Task<IActionResult> WaitForData()
    {
        // 设置超时时间，您可以根据需求进行调整
        var timeout = TimeSpan.FromSeconds(30);

        // 在指定的超时时间内等待新数据
        var cancellationTokenSource = new CancellationTokenSource();
        var dataTask = WaitForNewDataAsync(cancellationTokenSource.Token);

        if (await Task.WhenAny(dataTask, Task.Delay(timeout)) == dataTask)
        {
            // 如果有新数据可用，立即响应客户端请求
            cancellationTokenSource.Cancel();
            return Ok(dataTask.Result);
        }
        else
        {
            // 超时，返回204（NoContent）
            return NoContent();
        }
    }

    // 模拟异步获取新数据的过程，您可以替换为实际的数据源
    private async Task<string> WaitForNewDataAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken); // 模拟等待新数据的过程
        if (dataQueue.TryDequeue(out string data))
        {
            return data;
        }
        return null;
    }

    // 在其他地方更新数据的方法
    [HttpGet]
    public void AddData(string newData)
    {
        dataQueue.Enqueue(newData);
    }
}
