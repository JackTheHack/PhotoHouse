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

        public ActionResult UserData(OrderWizardModel model)
        {
            model.Order.ClientVkId = VKUser.viewer_id;

            return View(model);
        }

        private ViewResult GoToSelectPaper(OrderWizardModel model)
        {
            ViewBag.PaperTypeList =
                from value in Enum.GetNames(typeof(PaperFormat))
                select new SelectListItem()
                {
                    Selected = false,
                    Text = value,
                    Value = value
                };

            return View("SelectPaper", model);
        }

        public ActionResult SelectPaper(OrderWizardModel model)
        {
            return GoToSelectPaper(model);
        }

        public ActionResult SelectAlbum()
        {
            return View();
        }


        public ActionResult SelectPhotos(OrderWizardModel model)
        {
            return View(new OrderWizardModel()
            {
                Albums = model.Albums.Where(m => m.Checked).ToList(),
                Order = model.Order
            });
        }

        public ActionResult Submit(OrderWizardModel model)
        {
            using (var orders = new OrderDbManager())
            {
                orders.Add(model.Order);
                return View("Complete");
            }
        }

    }
}
