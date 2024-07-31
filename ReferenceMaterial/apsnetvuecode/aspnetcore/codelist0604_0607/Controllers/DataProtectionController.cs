using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace codelist0601_0612.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataProtectionController : ControllerBase
    {
        [HttpGet]
        public void RunSample(string input)
        {
            var key = "Sample.v1";

            string encryptData = EncryptData(input, key);
            Console.WriteLine($"EncryptData: {encryptData}");

            string decryptData = DecryptData(encryptData, key);
            Console.WriteLine($"DecryptData: {decryptData}");
        }

        // 代码清单6-4
        // 加密数据
        private string EncryptData(string data, string key)
        {
            byte[] encryptedBytes;

            var protector = DataProtectionProvider.Create(key).CreateProtector("MyApp.Encryption");
            var plainBytes = Encoding.UTF8.GetBytes(data);
            encryptedBytes = protector.Protect(plainBytes);

            return Convert.ToBase64String(encryptedBytes);
        }

        // 解密数据
        private string DecryptData(string encryptedData, string key)
        {
            byte[] decryptedBytes;

            var protector = DataProtectionProvider.Create(key).CreateProtector("MyApp.Encryption");
            byte[] encryptedBytes = Convert.FromBase64String(encryptedData);
            decryptedBytes = protector.Unprotect(encryptedBytes);

            return Encoding.UTF8.GetString(decryptedBytes);
        }

    }
}
