namespace TrendyolCaseStudy.Model
{
    public class Cart
    {
        #region factory methods

        public Cart(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        #endregion

        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}