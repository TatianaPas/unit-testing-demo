using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestingDemo;

namespace UnitTestProduct
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProductGetterCode()
        {
            Product p = new Product(123,"Laptop", 2000, 35);
            Assert.AreEqual(123, p.Code);
        }
        [TestMethod]
        public void TestProductSetterCode()
        {
            Product p = new Product(123, "Laptop", 2000, 35);
            p.Code = 100;
            Assert.AreEqual(100, p.Code);
        }
        [TestMethod]
        public void TestProductValidPrice()
        {
            Product p = new Product(123, "Laptop", 2000, 35);
            Assert.AreEqual(2000, p.Price);
        }
        [TestMethod]
        public void TestProductInValidLowerPrice()
        {
            Product p = new Product(123, "Laptop",2000, 35);
            try
            {
                p.Price = 0;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Please enter correct price", e.Message);
            }
            
        }
        [TestMethod]
        public void TestProductValidPriceSetter()
        {
            Product p = new Product(123, "Laptop", 2000, 35);
            p.Price = 1000;
            Assert.AreEqual(1000, p.Price);
        }

        [TestMethod]
        public void TestProductInValidPrice()
        {
            try
            {

            
            Product p = new Product(123, "Laptop", -2000, 35);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Please enter correct price", e.Message);
            }
            
        }

    }
}
