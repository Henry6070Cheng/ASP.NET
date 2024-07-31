using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lesson02_1.Pages
{
    public class IndexModel : PageModel
    {
        public string? Message { get; set; }

        public void OnGet()
        {
            Message = "Hello, Razor Pages!";
        }

    }
}