using System;
using iCodeSystems.ShoppingCart.CartServiceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iCodeSystems.ShoppingCart
{
    [TestClass]
    public class CartServiceTest
    {
        CartServiceClient client = new CartServiceClient();

        [TestMethod]
        public void GetCartTest()
        {
            var storedObj = client.GetCart(CartBaseTest.SAMPLE_CART_ID);

            Assert.IsNotNull(storedObj);
            Assert.IsInstanceOfType(storedObj, typeof(CartServiceReference.Cart));

            Assert.AreEqual(CartBaseTest.SAMPLE_CART_ID, storedObj.Id);            
        }
    }
}
