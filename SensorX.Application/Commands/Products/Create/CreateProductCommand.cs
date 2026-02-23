using MediatR;

namespace SensorX.Application.Commands.Products.Create;

public record CreateProductCommand(string Name, string Description, decimal Price) : IRequest<string>;
