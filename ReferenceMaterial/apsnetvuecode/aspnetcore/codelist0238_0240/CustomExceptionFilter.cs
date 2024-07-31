using Microsoft.AspNetCore.Mvc.Filters;

namespace codelist0238_0240;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        // 处理特定类型的异常
        Console.WriteLine("处理特定类型的异常");
    }
}

