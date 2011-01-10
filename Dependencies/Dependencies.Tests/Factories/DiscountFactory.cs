// <copyright file="DiscountFactory.cs">Copyright ©  2011</copyright>

using System;
using Microsoft.Pex.Framework;
using Dependencies;

namespace Dependencies
{
    /// <summary>A factory for Dependencies.Discount instances</summary>
    public static partial class DiscountFactory
    {
        /// <summary>A factory for Dependencies.Discount instances</summary>
        [PexFactoryMethod(typeof(Discount))]
        public static Discount Create(ICustomerRepository customerRepository_iCustomerRepository)
        {
            Discount discount = new Discount(customerRepository_iCustomerRepository);
            return discount;

            // TODO: Edit factory method of Discount
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
