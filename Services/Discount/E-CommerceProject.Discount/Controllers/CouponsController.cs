using E_CommerceProject.Discount.Dtos;
using E_CommerceProject.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceProject.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public CouponsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public async Task< IActionResult> CouponList() 
        {
            var values = await _discountService.GetResultCouponsAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            await _discountService.CreateCouponAsync(createCouponDto);
            return Ok("Kupon başarıyla oluşturuldu");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCouponAsync(int id)
        {
            await _discountService.DeleteCouponAsync(id);
            return Ok("Kupon silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCouponAsync(int id)
        {
            var values = await _discountService.GetCouponsById(id);
            return Ok(values);
        }
    }
}
