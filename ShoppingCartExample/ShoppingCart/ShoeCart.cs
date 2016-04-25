using ShoppingCartExample.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartExample.ShoppingCart
{
    public class ShoeCart : ShoppingCart<Shoe>
    {
        public ShoeCart(HttpContextBase context) : base(context)
        {
        }
    }
}