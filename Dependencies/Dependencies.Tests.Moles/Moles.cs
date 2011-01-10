using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Dependencies.Moles;
using Microsoft.Moles.Framework;
using Microsoft.Pex.Framework.Moles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Generated;
using Dependencies;
using Microsoft.Pex.Framework.Validation;

namespace Dependencies.Tests.Moles
{
    [TestClass]
    public partial class Moles
    {
        [PexMethod]
        public void TestMethod1(int customerId)
        {
            var repository = new SICustomerRepository();

            repository.GetCustomerInt32 = (int custId) =>
                                              {
                                                  return new Customer(PexChoose.Value<Level>("level"), PexChoose.Value<int>("points"));
                                              };

            var discount = new Discount(repository);

            discount.CalculateCustomerDiscount(customerId);
        }
    }
}
