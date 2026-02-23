using MediatR;
using SensorX.Application.Common.Interfaces;
using SensorX.Domain.AggregatesModel.ProductAggregate;
using SensorX.Domain.SeedWork;

namespace SensorX.Application.Commands.Products.Create;

public class CreateProductCommandHandler(
    IRepository<Product> productRepository,
    IUnitOfWork unitOfWork
) : IRequestHandler<CreateProductCommand, string>
{
    public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var productId = new ProductId(Guid.CreateVersion7());
        var product = new Product(productId, request.Name, request.Description, request.Price);

        productRepository.Add(product);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return product.Id.ToString();
    }
}
