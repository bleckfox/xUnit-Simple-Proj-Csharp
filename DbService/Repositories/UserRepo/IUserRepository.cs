using DbService.Entities;

namespace DbService.Repositories;

public interface IUserRepository
{
    User GetUserByIdAsync(int id);
    List<User> GetAllUsersAsync();
    void AddUserAsync(User user);
    void UpdateUserAsync(User user);
    void DeleteUserAsync(int id);
}
