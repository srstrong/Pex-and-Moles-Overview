using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dependencies.Tests.ByHand2
{
    [TestClass]
    public partial class ByHand2
    {
        [PexMethod]
        public void TestMethod1(int customerId)
        {
            var repository = new StubCustomerRepository();

            var discount = new Discount(repository);

            discount.CalculateCustomerDiscount(customerId);
        }
    }

    public class StubCustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(int customerId)
        {
            return new Customer(PexChoose.Value<Level>("level"), PexChoose.Value<int>("points"));
        }
    }
}
