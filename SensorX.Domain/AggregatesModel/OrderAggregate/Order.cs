using SensorX.Domain.SeedWork;

namespace SensorX.Domain.AggregatesModel.OrderAggregate;

public class Order(
    OrderId id,
    CustomerId customerId,
    CustomerInfo customerInfo,
    OrderStatus orderStatus,
    ShippingAddress shippingAddress,
    decimal totalAmount) : Entity<OrderId>(id), IAggregateRoot
{
    public CustomerId CustomerId { get; init; } = customerId;
    public CustomerInfo CustomerInfo { get; init; } = customerInfo;
    public OrderStatus OrderStatus { get; init; } = orderStatus;
    public ShippingAddress ShippingAddress { get; init; } = shippingAddress;
    public decimal TotalAmount { get; init; } = totalAmount;

    private readonly List<OrderItem> _items = [];
    public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();

    public void AddItem(
        string productName,
        string productCode,
        decimal unitPrice,
        int quantity)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(productName);
        ArgumentException.ThrowIfNullOrWhiteSpace(productCode);
        if (unitPrice < 0) throw new ArgumentException("Unit price cannot be negative");
        if (quantity < 0) throw new ArgumentException("Quantity cannot be negative");

        OrderItemId itemId = new(Guid.CreateVersion7());
        _items.Add(new OrderItem(itemId, productName, productCode, unitPrice, quantity));
    }
}