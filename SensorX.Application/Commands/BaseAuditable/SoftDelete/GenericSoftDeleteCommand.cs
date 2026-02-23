using MediatR;

namespace SensorX.Application.Commands.BaseAuditable.SoftDelete
{
    public abstract record GenericSoftDeleteCommand(List<Guid> Ids, long UserId) : IRequest<bool>;
}

