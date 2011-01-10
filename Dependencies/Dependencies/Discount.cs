using System;
using Dependencies;

namespace Dependencies
{
    public class Discount
    {
        private readonly ICustomerRepository _customerRepository;

        public Discount(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public int CalculateCustomerDiscount(int customerId)
        {
            var customer = _customerRepository.GetCustomer(customerId);
            int percentage;

            switch (customer.Level)
            {
                case Level.Gold:
                    percentage = 50;
                    break;
                case Level.Silver:
                    percentage = 30;
                    break;
                case Level.Bronze:
                    percentage = 10;
                    break;
                default:
                    throw new InvalidOperationException();
            }

            if (customer.Points > 1000)
            {
                percentage += 10;
            }
            else if (customer.Points > 500)
            {
                percentage += 5;
            }

            return percentage;
        }
    }
}
