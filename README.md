# UserRepository Project

Этот проект реализует простой репозиторий пользователей (`UserRepository`) с базовыми операциями CRUD и модульными тестами, написанными на C# с использованием xUnit. 

## Описание проекта

`UserRepository` предоставляет методы для управления списком пользователей в памяти. Класс реализует следующие операции:
- **Добавление пользователя** (`AddUserAsync`)
- **Получение пользователя по ID** (`GetUserByIdAsync`)
- **Получение всех пользователей** (`GetAllUsersAsync`)
- **Обновление информации о пользователе** (`UpdateUserAsync`)
- **Удаление пользователя** (`DeleteUserAsync`)

Класс `User` включает следующие свойства:
- `Id` (int): уникальный идентификатор пользователя
- `Name` (string): имя пользователя
- `Surname` (string): фамилия пользователя
- `Patronymic` (string): отчество пользователя
- `Email` (string): адрес электронной почты пользователя

## Требования

- .NET SDK (версия 6.0 или выше)
- xUnit

## Структура проекта

- `UserRepository.cs` — класс репозитория, содержащий CRUD-методы.
- `UserRepositoryTests.cs` — модульные тесты для `UserRepository`, проверяющие корректность каждой операции.

## Установка и запуск

1. Склонируйте репозиторий:
    ```bash
    git clone <url>
    cd <project-directory>
    ```

2. Соберите проект:
    ```bash
    dotnet build
    ```

3. Запустите тесты:
    ```bash
    dotnet test
    ```

## Использование

### Пример кода

Ниже приведен пример использования `UserRepository`:

```csharp
var userRepository = new UserRepository();

// Добавление нового пользователя
var user = new User { Id = 1, Name = "John", Surname = "Doe", Patronymic = "Michael", Email = "john.doe@example.com" };
userRepository.AddUserAsync(user);

// Получение пользователя по ID
var retrievedUser = userRepository.GetUserByIdAsync(1);
Console.WriteLine($"User: {retrievedUser.Name} {retrievedUser.Surname}");

// Обновление информации о пользователе
var updatedUser = new User { Id = 1, Name = "Jane", Surname = "Smith", Patronymic = "Anna", Email = "jane.smith@example.com" };
userRepository.UpdateUserAsync(updatedUser);

// Удаление пользователя
userRepository.DeleteUserAsync(1);
