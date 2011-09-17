using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Photoshop.DataAccess;
using Photoshop.Model;
using PhotoShopWebsite.Models;

namespace PhotoShopWebsite.Controllers
{
    public class OrderController : VKController
    {
        public ActionResult List()
        {
            using (var orders = new OrderDbManager())
            {
                return View(orders.GetList());
            }
        }

        public ActionResult SelectPaper(Order order)
        {
            return View();
        }

        public ActionResult SelectAlbum()
        {
            return View();
        }


        public ActionResult SelectPhotos(Order order, List<Album> selected)
        {
            return View(new SelectPhotosModel()
            {
                Albums = selected.Where(m => m.Checked).ToList(),
                Order = order
            });
        }

        public ActionResult Submit(Order order)
        {
            using (var orders = new OrderDbManager())
            {
                orders.Add(order);
                return View("Complete");
            }
        }

    }
}
