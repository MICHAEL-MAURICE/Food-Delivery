using Food_ordaring_app.ViewModels;
using food_ordering_app.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_ordaring_app.Services
{
    public class OrderRepository : IOrdertRepository
    {

        private readonly FoodorderingDbContext context;
        private readonly IProductOrderRepository ProductOrde;

        public OrderRepository(FoodorderingDbContext context, UserManager<AppUser> userManager, IProductOrderRepository ProductOrde)
        {
            this.context = context;
            this.ProductOrde = ProductOrde;
            
        }
        public Order Get(Guid id)
        {
            return context.Orders.FirstOrDefault(v => v.Id == id);
        }

        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public List<string> GetCustomersName()
        {
            return context.Orders.Select(c=>c.UserId).ToList(); 
        }

        public List<Order> GetbyId(string UserId)
        {
            return context.Orders.Where(o => o.UserId == UserId).ToList();
        }

        public void insert(OrderViewModel order)
        {
            Order newOrder = new Order();
            newOrder.UserId = order.UserId;
            newOrder.Date = order.Date;
            newOrder.Id = order.Id;
             var v = order.Product;
            context.Orders.Add(newOrder);
            context.SaveChanges();
            ProductOrde.Create(order.Id, order.productId);
        }
    }
}
