using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Photoshop.Model;

namespace PhotoShopWebsite.Controllers
{
    public class HomeController : VKController
    {
        public ActionResult Index(UserInfo user)
        {
            VKUser = user;
            return View();
        }
    }
}
