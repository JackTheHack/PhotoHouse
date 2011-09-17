using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Photoshop.Model;
using System.Linq.Expressions;

namespace PhotoShopWebsite.Controllers
{
    public class VKController : Controller
    {
        //
        // GET: /VK/

        public UserInfo VKUser
        {
            get { return HttpContext.Session["user"] as UserInfo; }
            set { HttpContext.Session["user"] = value; }
        }
    }
}
