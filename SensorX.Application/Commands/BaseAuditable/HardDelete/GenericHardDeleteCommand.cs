using MediatR;

namespace SensorX.Application.Commands.BaseAuditable.HardDelete
{
    public abstract record GenericHardDeleteCommand(List<Guid> Ids, long UserId) : IRequest<bool>;
}

