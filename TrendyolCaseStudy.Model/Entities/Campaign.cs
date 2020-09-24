namespace TrendyolCaseStudy.Model
{
    public class Campaign : Discount
    {
        #region factory methods

        public Campaign(Category category, int minAmount, decimal discountAmount, DiscountType discountType) : base(minAmount, discountAmount, discountType)
        {
            Category = category;
        }

        #endregion

        public Category Category { get; set; }
    }
}