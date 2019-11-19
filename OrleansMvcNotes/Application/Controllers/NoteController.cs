using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class NoteController : Controller
    {
        [HttpGet("/note")]
        public IActionResult Index()
        {
            return Ok("whatever");
        }
    }
}
