using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace wk2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubigyanController : Controller
    {
        public static List<Item> _items = new List<Item>()
        {
            new Item {Id = Guid.NewGuid(), Name = "Subigyan", Description = "This is Subigyan"},
            new Item {Id = Guid.NewGuid(), Name = "Subigyan", Description = "This is Subigyan"}
        };
        [HttpGet]
        public IActionResult Index()
        {
            // ReSharper disable once Mvc.ViewNotResolved
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_items);
        }

        public class Item
        {
            public Guid Id { get; set; }
            [Required(ErrorMessage = "Name is Require")]
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}
