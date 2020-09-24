using System;
using System.Collections.Generic;
using TrendyolCaseStudy.Business;
using TrendyolCaseStudy.Model;

namespace TrendyolCaseStudy.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            SetGlobalExceptionHandler();

            var electronicsCategory = new Category(CategoryNames.Electronics);
            var homeCategory = new Category(CategoryNames.Home);
            var gardencategory = new Category(CategoryNames.Garden, homeCategory);

            var campaigns = SetCampaignList(electronicsCategory, homeCategory, gardencategory);

            var shoppingCartService = new ShoppingCartService(new DeliveryCostCalculator(2M, 6M));
            shoppingCartService.SetCampaigns(campaigns);

            var macbookPro = new Product(ProductNames.MacbookPro, 1200.00M, electronicsCategory);
            var pillow = new Product(ProductNames.Pillow, 20.00M, homeCategory);
            var table = new Product(ProductNames.Table, 350.00M, gardencategory);

            var carts = SetCartList(macbookPro, pillow, table);
            shoppingCartService.SetCarts(carts);

            var coupon = new Coupon(minAmount: 1, discountAmount: 5, DiscountType.Amount);
            shoppingCartService.SetCoupon(coupon);

            Console.WriteLine(shoppingCartService.Print());
            Console.ReadKey();
        }

        static void SetGlobalExceptionHandler()
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
            Environment.Exit(0);
        }

        static List<Campaign> SetCampaignList(Category electronicsCategory, Category homeCategory, Category gardencategory)
        {
            return new List<Campaign>
            {
                new Campaign(electronicsCategory, minAmount: 5, discountAmount: 10, DiscountType.Rate),
                new Campaign(homeCategory, minAmount: 1, discountAmount: 30, DiscountType.Rate),
                new Campaign(gardencategory, minAmount: 1, discountAmount: 30, DiscountType.Rate),
            };
        }

        static List<Cart> SetCartList(Product macbookPro, Product pillow, Product table)
        {
            return new List<Cart>
            {
                new Cart(macbookPro,5),
                new Cart(pillow,2),
                new Cart(table,1)
            };
        }
    }
}