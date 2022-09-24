using Food_ordaring_app.Models;
using food_ordering_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_ordaring_app.Services
{
    public class ProductOrderRepository : IProductOrderRepository
    {

        private readonly FoodorderingDbContext context;

        public ProductOrderRepository(FoodorderingDbContext context)
        {
            this.context = context;
        }
        public void Create(Guid OrderId, int ProductId)

        {
            ProductOrder ProductOrder= new ProductOrder();
            ProductOrder.OrderId = OrderId;
            ProductOrder.ProductId = ProductId;
           context.ProductOrder.Add(ProductOrder);
            context.SaveChanges();
        }

        public List<ProductOrder> GetAll()
        {
            return context.ProductOrder.ToList();
        }

        public ProductOrder GetProduct(int id)
        {
            return context.ProductOrder.FirstOrDefault(v => v.Id == id);
        }
    }
}
