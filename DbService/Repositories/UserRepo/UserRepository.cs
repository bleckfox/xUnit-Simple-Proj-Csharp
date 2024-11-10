using DbService.Entities;

namespace DbService.Repositories;

public class UserRepository : IUserRepository
{
    private List<User> _users = [];

    public void AddUserAsync(User user) => _users.Add(user);

    public void DeleteUserAsync(int id) => _users.Remove(GetUserByIdAsync(id));

    public List<User> GetAllUsersAsync() => _users;

    public User GetUserByIdAsync(int id) => _users.First(u => u.Id == id);

    public void UpdateUserAsync(User user)
    {
        User oldUser = GetUserByIdAsync(user.Id);

        oldUser.Name = user.Name;
        oldUser.Surname = user.Surname;
        oldUser.Patronymic = user.Patronymic;
        oldUser.Email = user.Email;
    }
}
