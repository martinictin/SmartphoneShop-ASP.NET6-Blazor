namespace SmartphoneShop.Client.Services.AuthService
{
    public interface IAuthenticationService
    {
        Task<ServiceResponse<int>> Register(UserRegister userRegister);
        Task<ServiceResponse<string>> Login(UserLogin userLogin);
        Task<ServiceResponse<bool>> ChangePassword(UserChangePassword userChangePassword);
    }
}
