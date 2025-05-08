using System.ComponentModel.DataAnnotations;

namespace Plutus.Domain.Common;

public class BaseEntity<T>
{
    protected BaseEntity()
    {
    }

    [MaxLength(64)]
    public T Id { get; protected set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [MaxLength(64)]
    public string? CreatedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    [MaxLength(64)] 
    public string? ModifiedBy { get; set; }
    public DateTime? RemovedAt { get; set; }
    public string? RemovedBy { get; set; }
}