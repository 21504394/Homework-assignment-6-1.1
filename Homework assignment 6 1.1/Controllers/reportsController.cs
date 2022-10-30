using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework_assignment_6_1._1.Models;
using System.Data.Entity;

namespace Homework_assignment_6_1._1.Controllers
{
    public class reportsController : Controller
    {
        // GET: reports
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: Report
        public ActionResult Index()
        {
            int[] months =
            {
                db.order_items.Where(z => z.order.order_date.Month == 1 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 2 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 3 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 4 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 5 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 6 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 7 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 8 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 9 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 10 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 11 && z.product.category_id == 6).ToList().Sum(z => z.quantity),
                db.order_items.Where(z => z.order.order_date.Month == 12 && z.product.category_id == 6).ToList().Sum(z => z.quantity)
            };
            return View(months);
        }
    }
}