using Discount.GRPC.Entities;

namespace Discount.API.Entities.Repositories
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon counpon);
        Task<bool> UpdateDiscount(Coupon counpon);
        Task<bool> DeleteDiscount(string productName);
    }
}
