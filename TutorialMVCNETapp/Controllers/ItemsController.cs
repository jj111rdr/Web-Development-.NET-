using Microsoft.AspNetCore.Mvc;
using TutorialMVCNETapp.Models;
namespace TutorialMVCNETapp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "keyboard"};
            return View(item);
        }
    }
}
