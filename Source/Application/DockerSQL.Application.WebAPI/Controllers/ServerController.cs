using Microsoft.AspNetCore.Mvc;

namespace DockerSQL.Application.WebAPI.Controllers
{
    /// <summary>
    /// Server Controller
    /// </summary>
    [Route("api/[controller]")]
    public class ServerController : Controller
    {
        /// <summary>
        /// Verifying API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetAsync()
        {
            return "It's Working! DockerSQL API 1.0.";
        }
    }
}
