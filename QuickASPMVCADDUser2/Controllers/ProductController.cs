using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickASPMVCADDUser2.Models;

namespace QuickASPMVCADDUser2.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult ProductHtml()
        {
            ViewBag.Message = "Your product Page.";
            return View();
        }

        // GET: Product
        //[HttpPost]
        //public ActionResult ProductHtml(ProductModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        //        sb.Append("Product Name :" + model.Name + "</br/>");
        //        sb.Append("Description :" + model.Description + "</br/>");
        //        sb.Append("Manufacturer :" + model.Manufacturer + "</br/>");
        //        sb.Append("Price :" + model.BasePrice + "</br/>");
        //        sb.Append("Category :" + model.Category[model.CategoryId - 1].Text);
        //        return Content(sb.ToString());
        //    }
        //    else
        //    {
        //        return View(model);
        //    }
        //}
    }
}