using MediatR;

namespace SensorX.Application.Commands.Auth.Login;

public record LoginCommand(string Username, string Password) : IRequest<string>;
