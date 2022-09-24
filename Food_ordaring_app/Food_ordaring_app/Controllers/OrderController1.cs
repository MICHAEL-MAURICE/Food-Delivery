using Food_ordaring_app.Services;
using food_ordering_app.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace Food_ordaring_app.Controllers
{
    public class OrderController1 : Controller
    {
        private readonly IOrderServices orderServices;
        
        private readonly IOrdertRepository orderRepo;
        private readonly IToastNotification _toastNotification;
        public OrderController1(IOrderServices orderServices, IOrdertRepository order, IToastNotification _toastNotification)
        {
           this.orderServices = orderServices;
            this.orderRepo = order;
            this._toastNotification = _toastNotification;
        }

        public ActionResult Index()
        {
            return View(orderRepo.GetAll());
        }

      
        public ActionResult Details(int id)
        {
            return View();
        }

        
       

        
       
        public ActionResult Create(int Productid , string userId)
        {
            

                var order= orderServices.Create(Productid, userId);
                orderRepo.insert(order);
            _toastNotification.AddSuccessToastMessage("Ordered successfully");

            return RedirectToAction("Index", "Home");
               
            
          

           
        }

        // GET: OrderController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
