namespace TrendyolCaseStudy.Business.Abstract
{
    public interface IDeliveryCostCalculator
    {
        decimal Calculate(IShoppingCartService shoppingCartService);
    }
}