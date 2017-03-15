using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            //return View();
            return "I am a method from StoreController.And my name is Index().";
        }
        public string Browser(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse,Genre=" + genre);
            return message;
        }
        public string Details(string id)
        {
            return "I am from Store Controller Browser().ID="+id;
        }
    }
}