using System.ComponentModel.DataAnnotations;

namespace DbService.Entities;

/// <summary>
/// Сущность пользователя
/// </summary>
public class User : BaseEntity
{
    /// <summary>
    /// Имя
    /// </summary>
    [Required]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Фамилия
    /// </summary>
    [Required]
    public string Surname { get; set; } = null!;
    
    /// <summary>
    /// Отчество
    /// </summary>
    public string? Patronymic { get; set; }

    /// <summary>
    /// Почта
    /// </summary>
    [EmailAddress]
    [Required]
    public string Email { get; set; } = null!;
}
