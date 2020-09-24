using System;
using TrendyolCaseStudy.Business.Abstract;

namespace TrendyolCaseStudy.Business
{
    public class DeliveryCostCalculator : BaseService, IDeliveryCostCalculator
    {
        #region ctor

        public decimal CostPerDelivery { get; private set; }
        public decimal CostPerProduct { get; private set; }
        public decimal FixedCost { get; private set; }

        public DeliveryCostCalculator(decimal costPerDelivery, decimal costPerProduct, decimal fixedCost = 6.99M)
        {
            CostPerDelivery = costPerDelivery;
            CostPerProduct = costPerProduct;
            FixedCost = fixedCost;
        }

        #endregion

        public decimal Calculate(IShoppingCartService shoppingCartService)
        {
            if (shoppingCartService == null)
            {
                throw new ArgumentNullException($"{SetMethodNameForMessage(nameof(Calculate))} is Null");
            }

            var numberOfDeliveries = shoppingCartService.GetNumberOfDeliveries();
            var numberOfProducts = shoppingCartService.GetNumberOfProducts();
            return (CostPerDelivery * numberOfDeliveries) + (CostPerProduct * numberOfProducts) + FixedCost;
        }
    }
}