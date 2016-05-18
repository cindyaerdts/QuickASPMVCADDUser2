using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickASPMVCADDUser2.Models;

namespace QuickASPMVCADDUser2.Controllers
{
    public class AddUserController : Controller
    {
        // GET: AddUser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FindUser()
        {
            User user = new User();
            return View(user);
        }

        //public ViewResult FindUser(string currentFilter, string userName, int? page)
        //{
        //    if (userName != null)
        //    {
        //        page = 1;
        //    }
        //    else
        //    {
        //        userName = currentFilter;
        //    }

        //    ViewBag.CurrentFilter = userName;

        //    if (!String.IsNullOrEmpty(userName))
        //    {
        //        try
        //        {
        //            //On real server, query List posible IP-adresses/ 
        //            //check wich IP-adress reacts 1st. 
        //            DomainContext = new PrincipalContext(
        //                ContextType.Domain,
        //                null,   //default domain
        //                "192.168.1.102");

        //            user1 = UserPrincipal.FindByIdentity(
        //            DomainContext,
        //            userName);

        //        }
        //        catch (Exception errorMessage)
        //        {
        //            Debug.WriteLine("Couldn't connect to Atos domain. ErrorMessage:" + errorMessage);
        //        }
        //    }

        //    int pageSize = 3;
        //    int pageNumber = (page ?? 1);
        //    return View();



        //}
    }
}