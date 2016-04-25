using ShoppingCartExample.Models.BaseModels;
using ShoppingCartExample.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartExample.Controllers
{
    public class HomeController : BaseController
    {



        // GET: Home
        public ActionResult Index()
        {
            Shoe shoe = new Shoe();
            shoe.ID = 1;
            shoe.Name = "Nike";
            shoe.Image = "Nike.jpg";
            return View(shoe);
        }
    }
}