using SensorX.Application.Common.Interfaces;
using SensorX.Domain.AggregatesModel.ProductAggregate;
using SensorX.Domain.SeedWork;
using MediatR;

namespace SensorX.Application.Commands.Products.Create;

public class CreateProductCommandHandler(IRepository<Product> productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, long>
{
    private readonly IRepository<Product> _productRepository = productRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product(request.Name, request.Description, request.Price);

        _productRepository.Add(product);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return product.Id;
    }
}
