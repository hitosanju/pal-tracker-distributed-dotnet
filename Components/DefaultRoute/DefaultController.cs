using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace DefaultRoute
{
    [Authorize(Policy = "pal-tracker")]
    [Route("")]
    public class DefaultController : Controller
    {
        [HttpGet]
        public string Default() => "Noop!";
    }
}