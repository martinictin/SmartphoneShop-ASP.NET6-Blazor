namespace SmartphoneShop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem cartItem);
        Task<List<CartItem>> GetCartItems();
        Task<List<CartProduct>> GetCartProducts();
        Task RemoveProductFromCart(int productId);
        Task UpdateQuantity(CartProduct product);
    }
}
