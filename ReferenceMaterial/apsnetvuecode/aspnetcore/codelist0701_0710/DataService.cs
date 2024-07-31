namespace codelist0701;

public interface IDataService
{
    Task<string> GetDataAsync();
}
public class DataService: IDataService
{
    public async Task<string> GetDataAsync()
    {
        await Task.Delay(3000);// 模拟一个耗时操作

        return "Ok";
    }
}
