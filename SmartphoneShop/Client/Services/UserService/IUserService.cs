namespace SmartphoneShop.Client.Services.UserService
{
    public interface IUserService
    {
        event Action OnChange;
        List<User> Users { get; set; }
        Task GetUsers();
        Task UpdateUser(User user);
        Task DeleteUser(int userId);
        Task AddUser(User user);
        User CreateNewUser();
    }
}
