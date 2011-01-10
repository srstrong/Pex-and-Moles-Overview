using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dependencies.Tests.ByHand
{
    [TestClass]
    public partial class ByHand
    {
        [PexMethod]
        public void TestMethod1(int customerId, Level level, int points)
        {
            var repository = new StubCustomerRepository(level, points);

            var discount = new Discount(repository);

            discount.CalculateCustomerDiscount(customerId);
        }
    }

    public class StubCustomerRepository : ICustomerRepository
    {
        private readonly Level _level;
        private readonly int _points;

        public StubCustomerRepository(Level level, int points)
        {
            _level = level;
            _points = points;
        }

        public Customer GetCustomer(int customerId)
        {
            return new Customer(_level, _points);
        }
    }
}
