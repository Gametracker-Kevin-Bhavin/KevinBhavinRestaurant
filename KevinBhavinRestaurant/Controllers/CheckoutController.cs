using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KevinBhavinRestaurant.Models;
using KevinBhavinRestaurant;

namespace KevinBhavinRestaurant.Controllers
{
    [Authorize(Roles = "admin")]
    public class CheckoutController : Controller
    {
        RestaurauntOrderCartContext storeDB = new RestaurauntOrderCartContext();
        private const string PromoCode = "FREE";

        //
        // GET: /Checkout/AddressAndPayment
        [Authorize]
        public ActionResult AddressAndPayment()
        {
            return View();
        }

        //
        // POST: /Checkout/AddressAndPayment
        [Authorize]
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);

            try
            {
                if (string.Equals(values["PromoCode"], PromoCode,
                    StringComparison.OrdinalIgnoreCase) == false)
                {
                    return View(order);
                }
                else
                {
                    order.name = User.Identity.Name;
                    order.datetime = DateTime.Now;

                    //Save Order
                    storeDB.Orders.Add(order);
                    storeDB.SaveChanges();
                    //Process the order
                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    

                    return RedirectToAction("Complete", new { id = cart.CreateOrder(order) });
                }
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }
        //
        // GET: /Checkout/Complete
        [Authorize]
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = storeDB.Orders.Any(
                o => o.id == id &&
                o.name== User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}