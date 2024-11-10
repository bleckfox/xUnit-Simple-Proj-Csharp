using DbService.Entities;
using DbService.Repositories;

namespace DbService.Test;

public class UserRepoTest
{
    private readonly UserRepository _userRepository;

    public UserRepoTest()
    {
        _userRepository = new UserRepository();
    }

    [Fact]
    public void AddUserAsync_ShouldAddUserToRepository()
    {
        // Arrange
        User user = new() 
        { 
            Id = 1, 
            Name = "John", 
            Surname = "Doe", 
            Patronymic = "Michael", 
            Email = "john.doe@example.com" 
        };

        // Act
        _userRepository.AddUserAsync(user);

        // Assert
        Assert.Contains(user, _userRepository.GetAllUsersAsync());
    }

    [Fact]
    public void GetUserByIdAsync_ShouldReturnCorrectUser_WhenUserExists()
    {
        // Arrange
        var user = new User { Id = 1, Name = "John", Surname = "Doe", Patronymic = "Michael", Email = "john.doe@example.com" };
        _userRepository.AddUserAsync(user);

        // Act
        var result = _userRepository.GetUserByIdAsync(1);

        // Assert
        Assert.Equal(user, result);
    }

    [Fact]
    public void GetUserByIdAsync_ShouldThrowException_WhenUserDoesNotExist()
    {
        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => _userRepository.GetUserByIdAsync(99));
    }

    [Fact]
    public void UpdateUserAsync_ShouldUpdateUserProperties()
    {
        // Arrange
        var user = new User { Id = 1, Name = "John", Surname = "Doe", Patronymic = "Michael", Email = "john.doe@example.com" };
        _userRepository.AddUserAsync(user);

        var updatedUser = new User { Id = 1, Name = "Jane", Surname = "Smith", Patronymic = "Anna", Email = "jane.smith@example.com" };

        // Act
        _userRepository.UpdateUserAsync(updatedUser);

        // Assert
        var result = _userRepository.GetUserByIdAsync(1);
        Assert.Equal("Jane", result.Name);
        Assert.Equal("Smith", result.Surname);
        Assert.Equal("Anna", result.Patronymic);
        Assert.Equal("jane.smith@example.com", result.Email);
    }

    [Fact]
    public void DeleteUserAsync_ShouldRemoveUserFromRepository()
    {
        // Arrange
        var user = new User { Id = 1, Name = "John", Surname = "Doe", Patronymic = "Michael", Email = "john.doe@example.com" };
        _userRepository.AddUserAsync(user);

        // Act
        _userRepository.DeleteUserAsync(1);

        // Assert
        Assert.DoesNotContain(user, _userRepository.GetAllUsersAsync());
    }

    [Fact]
    public void DeleteUserAsync_ShouldThrowException_WhenUserDoesNotExist()
    {
        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => _userRepository.DeleteUserAsync(99));
    }
}