using AutoMapper;
using E_CommerceProject.Discount.Context;
using E_CommerceProject.Discount.Dtos;
using E_CommerceProject.Discount.Models;

namespace E_CommerceProject.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;
        private readonly IMapper _mapper;

        public DiscountService(DapperContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            var values= _mapper.Map<Coupon>(createCouponDto);
            await _context.Coupons.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public Task DeleteCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCouponDto> GetCouponsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCouponDto>> GetResultCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {
            throw new NotImplementedException();
        }
    }
}
