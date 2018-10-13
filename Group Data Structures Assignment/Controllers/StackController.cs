using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group_Data_Structures_Assignment.Controllers
{
    public class StackController : Controller
    {
        static Stack<string> myStack = new Stack<string>();
        // GET: Stack
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Exit()
        {
            return Redirect("https://www.byu.edu");
        }
    }
}