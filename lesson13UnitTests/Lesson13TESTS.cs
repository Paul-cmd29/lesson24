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
            string? result = customer.ToString();
            Assert.NotNull(result);
        }

        [Fact]
        public void test2()
        {
            ProductInfo product = new ProductInfo();
            string? result = product.ToString();
            Assert.Contains(result, "Product");
        }
       

    }
}

