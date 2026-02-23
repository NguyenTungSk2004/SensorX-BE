using SensorX.Domain.SeedWork;

namespace SensorX.Domain.AggregatesModel.ProductAggregate;

public class Product(ProductId id, string name, string description, decimal price) : AuditEntity(id), IAggregateRoot
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public decimal Price { get; private set; } = price;

    public void UpdateDetails(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}
