using SmartphoneShop.Shared;
using System.Net.Http.Json;

namespace SmartphoneShop.Client.Services.AuthService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _http;
        public AuthenticationService(HttpClient http)
        {
            _http = http;   
        }

        public async Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/change-password", request.Password);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }


        public async Task<ServiceResponse<string>> Login(UserLogin userLogin)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", userLogin);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister userRegister)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", userRegister);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
