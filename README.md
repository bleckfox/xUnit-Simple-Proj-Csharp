# UserRepository Project

���� ������ ��������� ������� ����������� ������������� (`UserRepository`) � �������� ���������� CRUD � ���������� �������, ����������� �� C# � �������������� xUnit. 

## �������� �������

`UserRepository` ������������� ������ ��� ���������� ������� ������������� � ������. ����� ��������� ��������� ��������:
- **���������� ������������** (`AddUserAsync`)
- **��������� ������������ �� ID** (`GetUserByIdAsync`)
- **��������� ���� �������������** (`GetAllUsersAsync`)
- **���������� ���������� � ������������** (`UpdateUserAsync`)
- **�������� ������������** (`DeleteUserAsync`)

����� `User` �������� ��������� ��������:
- `Id` (int): ���������� ������������� ������������
- `Name` (string): ��� ������������
- `Surname` (string): ������� ������������
- `Patronymic` (string): �������� ������������
- `Email` (string): ����� ����������� ����� ������������

## ����������

- .NET SDK (������ 6.0 ��� ����)
- xUnit

## ��������� �������

- `UserRepository.cs` � ����� �����������, ���������� CRUD-������.
- `UserRepositoryTests.cs` � ��������� ����� ��� `UserRepository`, ����������� ������������ ������ ��������.

## ��������� � ������

1. ����������� �����������:
    ```bash
    git clone <url>
    cd <project-directory>
    ```

2. �������� ������:
    ```bash
    dotnet build
    ```

3. ��������� �����:
    ```bash
    dotnet test
    ```

## �������������

### ������ ����

���� �������� ������ ������������� `UserRepository`:

```csharp
var userRepository = new UserRepository();

// ���������� ������ ������������
var user = new User { Id = 1, Name = "John", Surname = "Doe", Patronymic = "Michael", Email = "john.doe@example.com" };
userRepository.AddUserAsync(user);

// ��������� ������������ �� ID
var retrievedUser = userRepository.GetUserByIdAsync(1);
Console.WriteLine($"User: {retrievedUser.Name} {retrievedUser.Surname}");

// ���������� ���������� � ������������
var updatedUser = new User { Id = 1, Name = "Jane", Surname = "Smith", Patronymic = "Anna", Email = "jane.smith@example.com" };
userRepository.UpdateUserAsync(updatedUser);

// �������� ������������
userRepository.DeleteUserAsync(1);
