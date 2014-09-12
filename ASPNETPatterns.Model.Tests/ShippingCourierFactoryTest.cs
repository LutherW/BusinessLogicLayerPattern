using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASPNETPatterns.Model.Tests
{
    [TestClass]
    public class ShippingCourierFactoryTest
    {
        [TestMethod]
        public void UKShippingCourierFactory_Should_Create_DHL_Shipping_Courier_For_An_Order_With_A_Weight_In_KG_Over_100()
        {
            Order order = new Order() { TotalCost = 101.00M, WeightInKG = 6.00M };
            IShippingCourier shippingCourier = ShippingCourierFactory.CreateShippingCourier(order);
            Assert.IsInstanceOfType(shippingCourier, typeof(DHL));
        }
    }
}
