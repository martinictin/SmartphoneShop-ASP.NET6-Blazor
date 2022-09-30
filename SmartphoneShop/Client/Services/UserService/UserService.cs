using SmartphoneShop.Client.Pages.Admin;
using static System.Net.WebRequestMethods;

namespace SmartphoneShop.Client.Services.UserService
{
    public class UserService : IUserService
    {
        public event Action OnChange;
        public List<User> Users { get; set; } = new List<User>();
        private readonly HttpClient _http;
        public UserService(HttpClient http)
        {
            _http = http;   
        }
        public async Task AddUser(User user)
        {
            var response = await _http.PostAsJsonAsync("api/admin/users", user);
            await GetUsers();
            OnChange.Invoke();
        }

        public async Task DeleteUser(int usersId)
        {
            var response = await _http.DeleteAsync($"api/admin/users{usersId}");
            Users = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<User>>>()).Data;
            await GetUsers();
            OnChange.Invoke();
        }

        public async Task GetUsers()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<User>>>("api/admin/users");
            if (response != null && response.Data != null)
                Users = response.Data;
        }

        public async Task UpdateUser(User user)
        {
            var response = await _http.PutAsJsonAsync("api/admin/users", user);
            Users = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<User>>>()).Data;
            await GetUsers();
            OnChange.Invoke();
        }

        public User CreateNewUser()
        {
            var newUser = new User ();
            Users.Add(newUser);
            OnChange.Invoke();
            return newUser;
        }
    }
}
