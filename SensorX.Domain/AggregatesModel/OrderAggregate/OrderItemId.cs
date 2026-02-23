using SensorX.Domain.SeedWork;

namespace SensorX.Domain.AggregatesModel.OrderAggregate;

public record OrderItemId(Guid Id) : VoId(Id);