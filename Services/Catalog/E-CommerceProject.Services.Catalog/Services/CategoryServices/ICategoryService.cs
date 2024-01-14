using E_CommerceProject.Services.Catalog.Dtos.CategoryDtos;

namespace E_CommerceProject.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        void UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        void DeleteCategoryAsync(string id);
        Task<ResultCategoryDto> GetCategoryById(string id);
    }
}
