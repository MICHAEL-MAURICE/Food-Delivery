using Food_ordaring_app.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Food_ordaring_app.Controllers
{
    public class AdminController : Controller
    {
        private readonly IOrdertRepository orderRepo;
        public AdminController(IOrdertRepository orderRepo)
        {
            this.orderRepo = orderRepo;
        }
        public IActionResult Index()
        {
            return View(orderRepo.GetAll());
        }

        public IActionResult Customers(string UserId)
        {
            return View();
        }
        public IActionResult CustomerOrders(string UserId)
        {
            return View("CustomerOrders", orderRepo.GetbyId(UserId));
        }

        public IActionResult FilterByUserName()
        {
         
            return View("FilterByUserName", orderRepo.GetCustomersName());
        }


        public IActionResult getorderDetailes(Guid Id)
        {


            return PartialView("_OrderDetailes", orderRepo.Get(Id));
        }
    }
}
