
using ManuMaster.Entities;
using ManuMaster.Services.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace ManuMaster.Services;
public class ProductAppService : ApplicationService
{
    private readonly IRepository<Product, Guid> _productItemRepository;

    public ProductAppService(IRepository<Product, Guid> productItemRepository)
    {
        _productItemRepository = productItemRepository;
    }

    // TODO: Implement the methods here...
    public async Task<List<ProductDto>> GetListAsync()
    {
        var items = await _productItemRepository.GetListAsync();
        return items
            .Select(item => new ProductDto
            {
                Id = item.Id,
                Text = item.Text,
                Price = item.Price,
                Quantity = item.Quantity,
                Manufactured = item.Manufactured,
                EntryDate = item.EntryDate,
                UpdatedDate = item.UpdatedDate,
            }).ToList();
    }
    public async Task<ProductDto> CreateAsync(string text)
    {
        var item = await _productItemRepository.InsertAsync(
            new Product { Text = text }
        );

        return new ProductDto
        {
            Id = item.Id,
            Text = item.Text,
            Price = item.Price,
            Quantity = item.Quantity,
            Manufactured = item.Manufactured,
            EntryDate = item.EntryDate,
            UpdatedDate = item.UpdatedDate,
        };
    }
    public async Task DeleteAsync(Guid id)
    {
        await _productItemRepository.DeleteAsync(id);
    }

}
