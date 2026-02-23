using SensorX.Domain.SeedWork;

namespace SensorX.Domain.AggregatesModel.OrderAggregate;

public record OrderId(Guid Id) : VoId(Id);