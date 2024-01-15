using E_CommerceProject.Discount.Dtos;

namespace E_CommerceProject.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultCouponDto>> GetResultCouponsAsync();
        Task CreateCouponAsync(CreateCouponDto createCouponDto);
        Task DeleteCouponAsync(int id);
        Task UpdateCouponAsync(UpdateCouponDto updateCouponDto);
        Task<ResultCouponDto> GetCouponsById(int id);
    }
}
