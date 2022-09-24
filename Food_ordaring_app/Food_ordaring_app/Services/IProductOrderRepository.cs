using Food_ordaring_app.Models;
using System;
using System.Collections.Generic;

namespace Food_ordaring_app.Services
{
    public interface IProductOrderRepository
    {
        public void Create(Guid OrderId, int ProductId);

        List<ProductOrder> GetAll();
        ProductOrder  GetProduct(int id);    

    }
}
