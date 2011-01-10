using Dependencies.Moles;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Moles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dependencies.Tests.MolesAndPex
{
    [TestClass]
    public class MolesAndPex
    {
        [PexMethod]
        public void TestMethod(int customerId)
        {
            var repository = new SICustomerRepository();

            repository.InstanceBehavior = PexChooseBehavedBehavior.Instance;

            var discount = new Discount(repository);

            discount.CalculateCustomerDiscount(customerId);
        }
    }
}
