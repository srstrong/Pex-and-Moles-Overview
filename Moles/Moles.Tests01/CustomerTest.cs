// <copyright file="CustomerTest.cs">Copyright ©  2011</copyright>

using System;
using System.IO.Moles;
using System.Moles;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moles;

namespace Moles
{
    [TestClass]
    [PexClass(typeof(Customer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CustomerTest
    {
        [PexMethod]
        public bool IsMinor([PexAssumeUnderTest]Customer target)
        {
            MDateTime.TodayGet = () => new DateTime(2011, 1, 1);

            PexAssume.IsTrue(target.DateOfBirth < new DateTime(2011, 1, 1));
            PexAssume.IsTrue(target.DateOfBirth > new DateTime(1850, 1, 1));
            PexObserve.Value("DateOfBirth", target.DateOfBirth);

            bool result = target.IsMinor();
            return result;
            // TODO: add assertions to method CustomerTest.IsMinor(Customer)
        }
        [PexMethod]
        public Customer Constructor(DateTime dateTime)
        {
            Customer target = new Customer(dateTime);
            return target;
            // TODO: add assertions to method CustomerTest.Constructor(DateTime)
        }
    }
}
