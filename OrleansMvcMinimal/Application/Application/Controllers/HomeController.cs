using System.Threading.Tasks;
using Application.Grains;
using Microsoft.AspNetCore.Mvc;
using Orleans;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClusterClient clusterClient;

        public HomeController(IClusterClient clusterClient)
        {
            this.clusterClient = clusterClient;
        }

        [Route("")]
        public async Task<IActionResult> Index()
        {
            var helloGrain = clusterClient.GetGrain<IHello>(0);
            var greeting = await helloGrain.SayHello("Hi there");
            return Ok(greeting);
        }
    }
}
