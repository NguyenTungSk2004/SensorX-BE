using SensorX.Domain.SeedWork;
using MediatR;

namespace SensorX.Application.Common.DomainEvent;
public record DomainEventNotification<TDomainEvent>(TDomainEvent DomainEvent): INotification where TDomainEvent : IDomainEvent;

