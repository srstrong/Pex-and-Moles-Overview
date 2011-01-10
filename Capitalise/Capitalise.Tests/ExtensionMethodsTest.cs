// <copyright file="ExtensionMethodsTest.cs">Copyright ©  2011</copyright>

using System;
using Capitalise;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capitalise
{
    [TestClass]
    [PexClass(typeof(ExtensionMethods))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ExtensionMethodsTest
    {
        [PexMethod]
        public string Capitalize(string value)
        {
            string result = ExtensionMethods.Capitalize(value);
            return result;
            // TODO: add assertions to method ExtensionMethodsTest.Capitalize(String)
        }

        [PexMethod]
        public void Capitalize2(string value)
        {
            var first = value.Capitalize();
            var second = first.Capitalize();
            Assert.AreEqual(first, second);
        }
    }
}
