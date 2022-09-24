using Food_ordaring_app.ViewModels;
using food_ordering_app.Models;
using System;
using System.Collections.Generic;

namespace Food_ordaring_app.Services
{
    public interface IOrdertRepository
    {
        List<Order> GetAll();

        Order Get(Guid id);
        void insert(OrderViewModel order);
        public List<Order> GetbyId(string UserId);
        public List<string> GetCustomersName();
    }
}
