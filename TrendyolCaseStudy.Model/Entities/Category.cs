namespace TrendyolCaseStudy.Model
{
    public class Category
    {
        #region factory methods

        public Category(string title)
        {
            Title = title;
        }

        public Category(string title, Category parentCategory) : this(title)
        {
            ParentCategory = parentCategory;
        }

        #endregion

        public string Title { get; set; }

        public Category ParentCategory { get; set; }
    }
}