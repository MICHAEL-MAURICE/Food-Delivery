using food_ordering_app.Models;
using System;

namespace Food_ordaring_app.ViewModels
{
    public class OrderViewModel
    {



        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public int productId { get; set; }  
        public string UserId { get; set; }
       
        public Product? Product { get; set; }
    }
}
