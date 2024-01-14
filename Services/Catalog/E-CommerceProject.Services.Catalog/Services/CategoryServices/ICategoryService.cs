using E_CommerceProject.Services.Catalog.Dtos.CategoryDtos;

namespace E_CommerceProject.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<ResultCategoryDto> GetCategoryById(string id);
    }
}
