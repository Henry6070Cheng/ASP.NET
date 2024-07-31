namespace codelist0604;

// 代码清单6-7
public class MyService
{
    private readonly IConfiguration _configuration;

    public MyService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetSecretValue()
    {
        return _configuration["MySecretKey"];
    }
}

