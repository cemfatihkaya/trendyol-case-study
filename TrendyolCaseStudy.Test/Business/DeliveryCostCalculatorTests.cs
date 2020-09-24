using NUnit.Framework;
using System;
using TrendyolCaseStudy.Business;
using TrendyolCaseStudy.Business.Abstract;

namespace TrendyolCaseStudy.Test.Business
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class DeliveryCostCalculatorTests : BaseTestFixture
    {
        #region members & setup

        DeliveryCostCalculator deliveryCostCalculator;

        StrictMock<IShoppingCartService> shoppingCartService;

        [SetUp]
        public void Initialize()
        {
            shoppingCartService = new StrictMock<IShoppingCartService>();
        }

        #endregion

        #region verify mocks

        protected override void VerifyMocks()
        {
            shoppingCartService.VerifyAll();
        }

        #endregion

        [Test]
        public void Calculate_NullCart_ReturnsArgumentNullException()
        {
            //Arrange
            deliveryCostCalculator = new DeliveryCostCalculator(2M, 6M);
            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => deliveryCostCalculator.Calculate(null));
        }

        [Test]
        public void Calculate_NoProduct_ReturnsFixedCost()
        {
            //Arrange
            deliveryCostCalculator = new DeliveryCostCalculator(2M, 6M);
            shoppingCartService.Setup(m => m.GetNumberOfDeliveries()).Returns(0);
            shoppingCartService.Setup(m => m.GetNumberOfProducts()).Returns(0);

            //Act

            //Assert
            var expectedResult = deliveryCostCalculator.Calculate(shoppingCartService.Object) == 6.99M;
            Assert.That(expectedResult);
        }

        [Test]
        public void Calculate_CartWithOneDeliveryOneProduct_ReturnsValidCalculation()
        {
            //Arrange
            deliveryCostCalculator = new DeliveryCostCalculator(2M, 6M);
            shoppingCartService.Setup(m => m.GetNumberOfDeliveries()).Returns(1);
            shoppingCartService.Setup(m => m.GetNumberOfProducts()).Returns(1);
            //Act

            //Assert
            var expectedResult = (2M * 1M) + (6M * 1M) + 6.99M;
            Assert.That(deliveryCostCalculator.Calculate(shoppingCartService.Object) == expectedResult);
        }
    }
}