using ShoppingCartExample.Models.BaseModels;
using ShoppingCartExample.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartExample.Controllers
{
    public class HomeController : Controller
    {
        ShoeCart shoeCart;

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            shoeCart = new ShoeCart(this.HttpContext);
            base.OnActionExecuting(filterContext);
        }


        // GET: Home
        public ActionResult Index()
        {
            Shoe shoe = new Shoe();
            shoe.ID = 1;
            shoe.Name = "Nike";
            shoe.Image = "Nike.jpg";
            return View(shoe);
        }

        public ActionResult ShoppingCart()
        {
            List<Shoe> itemsInCart = shoeCart.GetAll();
            return View(itemsInCart);
        }

        [HttpPost]
        public ActionResult AddCartItem(int id)
        {
            // AutoFactory ShoeFac Example: shoeFac.Get(id);
            // shoeCart.Add(shoeFac.Get(id));
            shoeCart.Add(new Shoe() { ID = id, Name = "Nike", Image = "Nike.jpg" });
            return RedirectToAction("ShoppingCart");
        }
    }
}