using SmartphoneShop.Shared.DTO;

namespace SmartphoneShop.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsAsync();
    Task<ServiceResponse<Product>> GetProductAsync(int productId);
    Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
    Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText,int page);
    Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
    Task<List<Product>> FindProductsBySearchText(string searchText);
    Task<ServiceResponse<List<Product>>> GetAdminProducts();
    Task<ServiceResponse<Product>> CreateProduct(Product product);
    Task<ServiceResponse<Product>> UpdateProduct(Product product);
    Task<ServiceResponse<bool>> DeleteProduct(int productId);
}