using AutoMapper;
using Dapper;
using E_CommerceProject.Discount.Context;
using E_CommerceProject.Discount.Dtos;
using E_CommerceProject.Discount.Models;

namespace E_CommerceProject.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;
        

        public DiscountService(DapperContext context)
        {
            _context = context;
            
        }

        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            string query = "insert into Coupons (Code, Rate, IsActive, ValidDate) values(@code, @rate, @isActive, @validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createCouponDto.Code);
            parameters.Add("@rate", createCouponDto.Rate);
            parameters.Add("@isActive", true);
            parameters.Add("@validDate",createCouponDto.ValidDate);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCouponAsync(int id)
        {
            string query = "Delete From Coupons Where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@couponID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<ResultCouponDto> GetCouponsById(int id)
        {
            string query = " Select * From Coupons Where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@couponID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<ResultCouponDto>(query,parameters);
                return values;
            }
        }

        public async Task<List<ResultCouponDto>> GetResultCouponsAsync()
        {
            string query = "Select * From Coupons";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCouponDto>(query);
                return values.ToList();
            }
        }

        public Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {
            throw new NotImplementedException();
        }
    }
}
