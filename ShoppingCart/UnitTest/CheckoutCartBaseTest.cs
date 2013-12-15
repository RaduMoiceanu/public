using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iCodeSystems.ShoppingCart
{
    [TestClass]
    public class CheckoutCartBaseTest
    {
        const string SAMPLE_CART_EMAIL = "john.doe@gmail.com";
        const string SAMPLE_CART_NAME = "John Doe";
        const string SAMPLE_CUSTOMER_ACCOUNT_ID = "1234321";
        const string BILLING_ADDRESS_1 = "30 Rock";
        const string BILLING_CITY = "New York";
        const string BILLING_ZIP = "10001";
        const string BILLING_STATE = "NY";
        const string BILLING_PHONE = "555-123-4567";
        const string BILLING_COUNTRY = "United States";
        const string SHIPPING_ATTENTION_TO = "Radu M";
        const string SHIPPING_COMPANY = "iCode Systems SRL";
        const string SHIPPING_ADDRESS_1 = "str Barbu Urleanu nr 20";
        const string SHIPPING_ADDRESS_2 = "etaj 2";
        const string SHIPPING_CITY = "Bucharest";
        const string SHIPPING_ZIP = "06881";
        const string SHIPPING_STATE = "Sector 5";
        const string SHIPPING_PHONE = "0722-276-000";
        const string SHIPPING_COUNTRY = "Romania";
        const string SAMPLE_CART_ID = "SampleCheckoutCartIdentifier";
        const string SAMPLE_CART_ITEM_ID_1 = "SampleCheckoutCartItem-1";
        const string SAMPLE_CART_ITEM_ID_2 = "SampleCheckoutCartItem-2";
        const string SAMPLE_SKU_1 = "565486521236";
        const string SAMPLE_SKU_2 = "213256595522";
        const int QUANTITY_1 = 1;
        const int QUANTITY_2 = 2;
        const string PROMO_CODE = "SpringSale2013";
        const string SAMPLE_ORDER_NUMBER = "4095263";
        readonly DateTime SAMPLE_ORDER_DATE = new DateTime(2013, 12, 16, 13, 2, 44);

        private readonly ICheckoutCart _sampleCart;


        public CheckoutCartBaseTest()
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

            IAddress billingAddress = new Address()
            {
                Type = AddressType.Billing,
                AttentionTo = SAMPLE_CART_NAME,
                Address1 = BILLING_ADDRESS_1,
                City = BILLING_CITY,
                PostalCode = BILLING_ZIP,
                Province = BILLING_STATE,
                Country = BILLING_COUNTRY,
                Phone = BILLING_PHONE
            };
            IAddress shippingAddress = new Address()
            {
                Type = AddressType.Shipping,
                AttentionTo = SHIPPING_ATTENTION_TO,
                CompanyName = SHIPPING_COMPANY,
                Address1 = SHIPPING_ADDRESS_1,
                Address2 = SHIPPING_ADDRESS_2,
                City = SHIPPING_CITY,
                PostalCode = SHIPPING_ZIP,
                Province = SHIPPING_STATE,
                Country = SHIPPING_COUNTRY,
                Phone = SHIPPING_PHONE
            };

            _sampleCart = new CheckoutCartBase()
            {
                Id = SAMPLE_CART_ID,
                Email = SAMPLE_CART_EMAIL,
                Name = SAMPLE_CART_NAME,
                CustomerAccountId = SAMPLE_CUSTOMER_ACCOUNT_ID
            };
            _sampleCart.Items.Add(item1);
            _sampleCart.Items.Add(item2);
            _sampleCart.PromotionCodes.Add(PROMO_CODE);
            _sampleCart.BillingAddress = billingAddress;
            _sampleCart.ShippingAddress = shippingAddress;
        }

        [TestMethod]
        public void SavePrePlaceTest()
        {
            DataServiceProvider<ICart>.Repository.Save(_sampleCart);
        }

        [TestMethod]
        public void GetPrePlaceTest()
        {
            var storedObj = DataServiceProvider<ICart>.Repository.Get(SAMPLE_CART_ID);

            Assert.IsNotNull(storedObj);
            Assert.IsInstanceOfType(storedObj, typeof(ICheckoutCart));

            Assert.AreEqual(SAMPLE_CART_EMAIL, (storedObj as ICheckoutCart).Email);
        }

        [TestMethod]
        public void SavePlaceTest()
        {
            _sampleCart.OrderNumber = SAMPLE_ORDER_NUMBER;
            _sampleCart.OrderDate = SAMPLE_ORDER_DATE;

            DataServiceProvider<ICart>.Repository.Save(_sampleCart);

            _sampleCart.OrderNumber = null;
            _sampleCart.OrderDate = default(DateTime);
        }

        [TestMethod]
        public void GetPlaceTest()
        {
            var storedObj = DataServiceProvider<ICart>.Repository.Get(SAMPLE_CART_ID);

            Assert.IsNotNull(storedObj);
            Assert.IsInstanceOfType(storedObj, typeof(ICheckoutCart));

            Assert.AreEqual(SAMPLE_CART_EMAIL, (storedObj as ICheckoutCart).Email);
            Assert.AreEqual(SAMPLE_ORDER_NUMBER, (storedObj as ICheckoutCart).OrderNumber);
            Assert.AreEqual(SAMPLE_ORDER_DATE, (storedObj as ICheckoutCart).OrderDate);
        }
    }
}
