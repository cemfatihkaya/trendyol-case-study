using System.Collections.Generic;
using TrendyolCaseStudy.Model;

namespace TrendyolCaseStudy.Business.Abstract
{
    public interface IShoppingCartService
    {
        decimal CalculateTotalAmount(List<Cart> baskets);

        decimal ApplyCampaign(decimal totalAmount);

        decimal ApplyCoupon(decimal totalAmount);

        int GetNumberOfDeliveries();

        int GetNumberOfProducts();

        decimal GetDeliveryCost();

        void SetCampaigns(List<Campaign> campaigns);

        void SetCarts(List<Cart> carts);

        void SetCoupon(Coupon coupon);
    }
}