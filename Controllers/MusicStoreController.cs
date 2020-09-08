using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class MusicStoreController : Controller
    {
        // GET: MusicStore
        public ActionResult Index()
        {
            return View();
        }
        public string ShowMusic(string MusicTitle)
        {
            return "You selected " + MusicTitle + " Music";
        }
    }
}