using Food_ordaring_app.ViewModels;

namespace Food_ordaring_app.Services
{
    public interface IOrderServices
    {
        OrderViewModel Create(int productId, string userId);
        
    }
}
