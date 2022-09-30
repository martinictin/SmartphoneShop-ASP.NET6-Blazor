namespace SmartphoneShop.Server.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetUsers();
        Task<ServiceResponse<List<User>>> AddUser(User user);
        Task<ServiceResponse<List<User>>> UpdateUser(User user);
        Task<ServiceResponse<List<User>>> DeleteUser(int id);
    }
}
