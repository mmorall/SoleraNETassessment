using Microsoft.AspNetCore.Mvc;
using Solera_NetC_Assessment.Models;

namespace Solera_NetC_Assessment.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(0, "desc0", "open", new DateOnly(), -1));
            claims.Add(new Claim(0, "desc0", "open", new DateOnly(), -1));
            claims.Add(new Claim(0, "desc0", "open", new DateOnly(), -1));
            claims.Add(new Claim(0, "desc0", "open", new DateOnly(), -1));
            return View();
        }
    }
}
