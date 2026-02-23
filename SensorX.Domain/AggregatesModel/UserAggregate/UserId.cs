using SensorX.Domain.SeedWork;

namespace SensorX.Domain.AggregatesModel.UserAggregate;

public record UserId(Guid id) : VoId(id);