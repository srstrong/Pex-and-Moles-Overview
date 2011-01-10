// <copyright file="ResizableArrayTTest.cs">Copyright ©  2011</copyright>

using System;
using Array;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Array
{
    [TestClass]
    [PexClass(typeof(ResizableArray<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ResizableArrayTTest
    {
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public void Add<T>(int capacity, T item)
        {
            var array = new ResizableArray<T>(capacity);
            array.Add(item);
            Assert.AreEqual(item, array[0]);
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public void AddN<T>(int capacity, T[] items)
        {
            var array = new ResizableArray<T>(capacity);

            foreach (var item in items)
            {
                array.Add(item);
                Assert.AreEqual(item, array[array.Length - 1]);                
            }
        }
    }
}
