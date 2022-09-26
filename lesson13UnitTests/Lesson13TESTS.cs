using System;
using lesson13_14;

namespace lesson13UnitTests
{
    public class Lesson13TESTS
    {
        [Fact]
        public void test1()
        {
            CustomerData customer = new CustomerData();
            string result = customer.ToString();
            Assert.NotNull(result);
        }

        [Fact]
        public void test2()
        {
            ProductInfo product = new ProductInfo();
            string result = product.ToString();
            Assert.Contains(result, "Product");
        }
        [Fact]
        public void test3()
        {
            ProductInfo product1 = new ProductInfo();
            string result = product1.ToString();
            Assert.NotNull(result);
        }


    }
}

