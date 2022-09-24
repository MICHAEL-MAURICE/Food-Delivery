using food_ordering_app.Models;
using System.Collections.Generic;
using System.Linq;

namespace Food_ordaring_app.Services
{
    public class ProuductRepository : IProuductRepository
    {

        private readonly FoodorderingDbContext context;

        public ProuductRepository(FoodorderingDbContext context)
        {
            this.context = context;
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList(); 
        }

        public Product GetbyId(int id)
        {
            return context.Products.FirstOrDefault(v => v.Id == id);
        }
    }
}
