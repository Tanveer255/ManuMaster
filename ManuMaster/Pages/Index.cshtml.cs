using ManuMaster.Services;
using ManuMaster.Services.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ManuMaster.Pages;

public class IndexModel : AbpPageModel
{
    public List<ProductDto> ProductItems { get; set; }

    private readonly ProductAppService _productItemRepository;

    public IndexModel(ProductAppService productItemRepository)
    {
        _productItemRepository = productItemRepository;
    }

    public async Task OnGetAsync()
    {
        ProductItems = await _productItemRepository.GetListAsync();
    }
}