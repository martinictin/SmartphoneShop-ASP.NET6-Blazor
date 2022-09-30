namespace SmartphoneShop.Client.Services.CategoryService
{
    public class UserService : ICategoryService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Category> Users { get; set; } = new List<Category>();

        public event Action OnChange;

        public async Task AddCategory(Category category)
        {
            var response = await _http.PostAsJsonAsync("api/Category/admin", category);
            Users = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
            await GetCategories();
            OnChange.Invoke();
        }

        public Category CreateNewCategory()
        {
            var newCategory = new Category { IsNew = true, Editing = true };
            Users.Add(newCategory);
            OnChange.Invoke();
            return newCategory;
        }

        public async Task DeleteCategory(int categoryId)
        {
            var response = await _http.DeleteAsync($"api/Category/admin/{categoryId}");
            Users = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
            await GetCategories();
            OnChange.Invoke();
        }

        public async Task GetAdminCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category/admin");
            if (response != null && response.Data != null)
                Users = response.Data;
        }

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (response != null && response.Data != null)
                Categories = response.Data;
        }

        public async Task UpdateCategory(Category category)
        {
            var response = await _http.PutAsJsonAsync("api/Category/admin", category);
            Users = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
            await GetCategories();
            OnChange.Invoke();
        }
    }
}