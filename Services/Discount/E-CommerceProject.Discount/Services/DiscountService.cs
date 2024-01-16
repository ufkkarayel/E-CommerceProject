﻿using AutoMapper;
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
            string query = "insert into Coupon (Code, Rate, IsActive, ValidDate) values(@code, @rate, @isActive, @validDate)";
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
            string query = "Delete From Coupon Where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@couponID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
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
