using Microsoft.AspNetCore.Mvc;

namespace lesson02_3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<string> _products = new List<string>
        {
            "Product 1",
            "Product 2",
            "Product 3"
        };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return _products;
        }

        [HttpPost]
        public IActionResult Post(string product)
        {
            _products.Add(product);
            return Ok();
        }

        [HttpPut("{index}")]
        public IActionResult Put(int index, string product)
        {
            if (index >= 0 && index < _products.Count)
            {
                _products[index] = product;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (index >= 0 && index < _products.Count)
            {
                _products.RemoveAt(index);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

    }
}