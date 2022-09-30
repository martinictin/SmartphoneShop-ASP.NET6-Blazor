using SmartphoneShop.Shared;

namespace SmartphoneShop.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<User>>> AddUser(User user)
        {
           
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return await GetUsers();
        }

        private async Task<User> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<ServiceResponse<List<User>>> DeleteUser(int id)
        {
            User user = await GetUserById(id);
            if (user == null)
            {
                return new ServiceResponse<List<User>>
                {
                    Success = false,
                    Message = "User not found."
                };
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await GetUsers();
        }

        public async Task<ServiceResponse<List<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return new ServiceResponse<List<User>>
            {
                Data = users
            };
        }

        public async Task<ServiceResponse<List<User>>> UpdateUser(User user)
        {
            var dbUsers = await GetUserById(user.Id);
            if (dbUsers == null)
            {
                return new ServiceResponse<List<User>>
                {
                    Success = false,
                    Message = "User not found."
                };
            }

            dbUsers.Email = user.Email;
            dbUsers.DateCreated = user.DateCreated;
            dbUsers.Role = user.Role;

            await _context.SaveChangesAsync();

            return await GetUsers();

        }
    }
    
}
