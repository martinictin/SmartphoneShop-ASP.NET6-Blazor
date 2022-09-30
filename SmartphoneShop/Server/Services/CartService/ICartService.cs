using SmartphoneShop.Shared.DTO;

namespace SmartphoneShop.Server.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProduct>>> GetCartProducts(List<CartItem> cartItems);
    }
}
