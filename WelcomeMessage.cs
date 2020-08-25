using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi
{
    public class WelcomeMessage
    {
        public string Message { get; set; }
        public WelcomeMessage(string message)
        {
            this.Message = message;
        }
    }
}
