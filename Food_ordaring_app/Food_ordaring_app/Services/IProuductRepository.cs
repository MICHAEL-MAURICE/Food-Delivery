using food_ordering_app.Models;
using System.Collections.Generic;

namespace Food_ordaring_app.Services
{
    public interface IProuductRepository
    {
        List<Product> GetAll();
        Product GetbyId(int id);

    }
}
