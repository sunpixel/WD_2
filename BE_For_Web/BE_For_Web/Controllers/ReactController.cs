using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BE_For_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        // GET: api/<React>

        // Will be doing basic JSON return for React application
        // Will return last Counted Number when called and Will Return Some other data

        [HttpGet]
        public string GetName() 
        {

            HttpContext.Response.Headers.Add("Location", "http://localhost:5173/");

            return "SunPixel";
        }
    }
}
