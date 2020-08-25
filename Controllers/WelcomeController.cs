using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class WelcomeController : Controller
    {
        public WelcomeMessage _message;
        public WelcomeController(WelcomeMessage message)
        {
            this._message = message;
        }
        [HttpGet]
        public string SayHello() => _message.Message;
    }
}
