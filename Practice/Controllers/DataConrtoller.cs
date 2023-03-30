using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class DataConrtoller : Controller
    {
        Entity entity=new Entity();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("getDat")]
        public JsonResult Get()
        {
            return new JsonResult(entity.GetAllData());
        }
    }
}
