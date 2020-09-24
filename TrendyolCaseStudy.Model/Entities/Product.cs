namespace TrendyolCaseStudy.Model
{
    public class Product
    {
        #region factory methods

        public Product(string title, decimal price, Category category)
        {
            Title = title;
            Price = price;
            Category = category;
        }

        #endregion

        public string Title { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }
    }
}