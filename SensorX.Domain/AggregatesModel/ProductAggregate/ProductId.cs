using SensorX.Domain.SeedWork;

namespace SensorX.Domain.AggregatesModel.ProductAggregate;

public record ProductId(Guid id) : VoId(id);