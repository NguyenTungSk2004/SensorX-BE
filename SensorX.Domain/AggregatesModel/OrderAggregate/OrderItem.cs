using SensorX.Domain.SeedWork;
namespace SensorX.Domain.AggregatesModel.OrderAggregate;

public class OrderItem(
    OrderItemId id,
    string productName,
    string productCode,
    decimal unitPrice,
    int quantity)
    : Entity<OrderItemId>(id)
{
    public string ProductName { get; private set; } = productName;
    public string ProductCode { get; private set; } = productCode;
    public decimal UnitPrice { get; private set; } = unitPrice;
    public int Quantity { get; private set; } = quantity;

    public static OrderItem Create(
        string productName,
        string productCode,
        decimal unitPrice,
        int quantity)
    {
        // Validation logic giữ nguyên
        ArgumentException.ThrowIfNullOrWhiteSpace(productName);
        ArgumentException.ThrowIfNullOrWhiteSpace(productCode);
        if (unitPrice < 0) throw new ArgumentException("Unit price cannot be negative");
        if (quantity < 0) throw new ArgumentException("Quantity cannot be negative");

        // Gọi Primary Constructor thông qua 'new'
        return new OrderItem(new OrderItemId(Guid.NewGuid()), productName, productCode, unitPrice, quantity);
    }
}