namespace TrendyolCaseStudy.Model
{
    public class Coupon : Discount
    {
        public Coupon(int minAmount, decimal discountAmount, DiscountType discountType) : base(minAmount, discountAmount, discountType)
        {
        }
    }
}