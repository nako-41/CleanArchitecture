namespace CleanArchitecture.Domain.Abstractions;
public abstract class Entity
{
    public string CarId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
