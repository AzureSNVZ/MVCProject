using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
  
        public ViewResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            return View();
        }
        /*public EmptyResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            return new EmptyResult();
        }
        public RedirectResult Index()
        {
            return Redirect("Home/Contact");
        }*/
    }
}