using ShoppingCartExample.Models.BaseModels;
using ShoppingCartExample.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartExample.Controllers
{
    public class BaseController : Controller
    {
        protected ShoeCart shoeCart;

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            shoeCart = new ShoeCart(this.HttpContext);

            ViewBag.ShoppingCart = shoeCart.GetAll();

            base.OnActionExecuting(filterContext);
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