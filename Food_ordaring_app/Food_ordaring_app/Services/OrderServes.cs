using Food_ordaring_app.ViewModels;
using food_ordering_app.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
namespace Food_ordaring_app.Services
{
    public class OrderServes: IOrderServices
    {

        private readonly IOrdertRepository order;
        private readonly IProuductRepository product;
        private readonly IProductOrderRepository ProductOrde;
        


        public OrderServes(IOrdertRepository order, IProuductRepository product, IProductOrderRepository ProductOrde)
        {
            this.order = order;
            this.product = product;
            this.ProductOrde = ProductOrde;



        }
     

        OrderViewModel IOrderServices.Create(int productId, string userId)
        {
            OrderViewModel order = new OrderViewModel();
            order.Id = Guid.NewGuid();
           order.productId=productId;
                order.Date = System.DateTime.Now;
            order.Product = product.GetbyId(productId);
            order.UserId = userId;
            return order;

        }
    }
}
