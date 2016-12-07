using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinBhavinRestaurant.Models;

namespace KevinBhavinRestaurant.ViewModel
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public float CartTotal { get; set; }
    }
}