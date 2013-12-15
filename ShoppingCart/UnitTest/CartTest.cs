using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iCodeSystems.ShoppingCart
{
    [TestClass]
    public class CartTest
    {
        const string SAMPLE_CART_ID = "SampleCartIdentifier";
        const string SAMPLE_CART_ITEM_ID_1 = "SampleCartItem-1";
        const string SAMPLE_CART_ITEM_ID_2 = "SampleCartItem-2";
        const string SAMPLE_SKU_1 = "465486521236";
        const string SAMPLE_SKU_2 = "113256595522";
        const int QUANTITY_1 = 1;
        const int QUANTITY_2 = 2;
        const string PROMO_CODE = "FallSale2013";

        private readonly ICart _sampleCart;


        public CartTest()
        {
            ICartItem item1 = new CartItemBase()
            {
                Id = SAMPLE_CART_ITEM_ID_1,
                Sku = SAMPLE_SKU_1,
                Quantity = QUANTITY_1
            };
            ICartItem item2 = new CartItemBase()
            {
                Id = SAMPLE_CART_ITEM_ID_2,
                Sku = SAMPLE_SKU_2,
                Quantity = QUANTITY_2
            };

            _sampleCart = new CartBase()
            {
                Id = SAMPLE_CART_ID
            };
            _sampleCart.Items.Add(item1);
            _sampleCart.Items.Add(item2);
            _sampleCart.PromotionCodes.Add(PROMO_CODE);
        }

        [TestMethod]
        public void SaveCartTest()
        {
            DataServiceProvider<ICart>.Repository.Save(_sampleCart);
        }

        [TestMethod]
        public void GetCartTest()
        {
            var storedObj = DataServiceProvider<ICart>.Repository.Get(SAMPLE_CART_ID);

            Assert.IsNotNull(storedObj);
            Assert.AreEqual(_sampleCart.Id, storedObj.Id);

            Assert.AreEqual(_sampleCart.Items.Count, storedObj.Items.Count);

            Assert.AreEqual(_sampleCart.Items[0].Id, storedObj.Items[0].Id);
            Assert.AreEqual(_sampleCart.Items[0].Sku, storedObj.Items[0].Sku);
            Assert.AreEqual(_sampleCart.Items[0].Quantity, storedObj.Items[0].Quantity);

            Assert.AreNotEqual(_sampleCart.Items[1].Id, storedObj.Items[0].Id);

            Assert.AreEqual(_sampleCart.Items[1].Id, storedObj.Items[1].Id);
            Assert.AreEqual(_sampleCart.Items[1].Sku, storedObj.Items[1].Sku);
            Assert.AreEqual(_sampleCart.Items[1].Quantity, storedObj.Items[1].Quantity);

            Assert.AreEqual(_sampleCart.PromotionCodes.Count, storedObj.PromotionCodes.Count);

            Assert.AreEqual(_sampleCart.PromotionCodes[0], storedObj.PromotionCodes[0]);
        }

        [TestMethod]
        public void DeleteCartTest()
        {
            DataServiceProvider<ICart>.Repository.Delete(SAMPLE_CART_ID);

            var storedObj = DataServiceProvider<ICart>.Repository.Get(SAMPLE_CART_ID);
            Assert.IsNull(storedObj);
        }
    }
}
