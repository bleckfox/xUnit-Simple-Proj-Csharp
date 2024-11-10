using System.ComponentModel.DataAnnotations;

namespace DbService.Entities;

/// <summary>
/// Базовый класс сущностей
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
}
