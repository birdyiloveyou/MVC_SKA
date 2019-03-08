using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_SKA.Models;

namespace MVC_SKA.Controllers
{
    public class PowerfulController : Controller
    {
        private Random _rnd = new Random();
        // GET: Powerful
        public ActionResult MoneyTemplate()
        {
            List<ViewModel> LST = new List<ViewModel>(50);

            for (int x = 1; x < 51; x++)
            {


                var model = new ViewModel()
                {
                    ID = x,
                    TYPE = rnT(),
                    DATE = rnD(),
                    PRICE = rnP()
                };
                LST.Add(model);
            }




            return View(LST);
        }
        public string rnD()
        {

            int range = 1 * 365; //5 years   

            String randomDate = DateTime.Today.AddDays(-_rnd.Next(range)).ToShortDateString();
            return randomDate;
        }

        public int rnP()
        {
            int x = _rnd.Next(1000, 20001);
            return x;

        }

        public String rnT()
        {
            int x = _rnd.Next(0, 2);
            string t;
            if (x == 0)
                t = "支出";

            else
                t = "收入";

            return t;

        }
    }
}