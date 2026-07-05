namespace ProductManagement.Application.Interfaces;

public interface IUnitofWork
{
    IProductRepository productRepository{ get; }
        Task SaveChangesAsync(CancellationToken cancellationToken = default);

}