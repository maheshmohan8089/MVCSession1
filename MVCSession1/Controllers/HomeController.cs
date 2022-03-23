using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSession1.Models;
using MVCSession1.Models.ViewModels;

namespace MVCSession1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Customer objCust = new Customer();
            objCust.CustomerId = 1;
            objCust.CustomerName = "Suresh";
            objCust.Address = "Address1";
            objCust.PostCode = "112233";
            objCust.StateId = 1;
 
            return View(objCust);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            Customer objCust = new Customer();
            objCust.CustomerId = 1;
            objCust.CustomerName = "Suresh";
            objCust.Address = "Address1";
            objCust.PostCode = "112233";
            objCust.StateId = 1;

            State objState = new State();
            objState.StateId = 1;
            objState.StateName = "Kerala";

            VMCustomerDetails obj = new VMCustomerDetails()
            {
                Customer = objCust,
                State = objState
            };

            return View(obj);
        }
    }
}