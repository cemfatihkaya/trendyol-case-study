namespace TrendyolCaseStudy.Model
{
    public abstract class Discount
    {
        #region factory methods

        protected Discount(int minimumAmount, decimal discountAmount, DiscountType discountType)
        {
            DiscountAmount = discountAmount;
            DiscountType = discountType;
            MinimumAmount = minimumAmount;
        }

        #endregion

        public int MinimumAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public DiscountType DiscountType { get; set; }
    }
}