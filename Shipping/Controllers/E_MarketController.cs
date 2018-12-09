using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shipping.Controllers
{
    public class E_MarketController : Controller
    {

        /// GET: E_Market
        public string Index()
        {
            return "This iS MY Default Action..xD";
        }

        public string Welcome()
        {
            return "Hello";
        }
    }
}