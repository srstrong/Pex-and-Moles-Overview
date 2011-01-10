using System;
using System.Moles;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moles;

namespace Moles
{
    [TestClass]
    [PexClass(typeof(Class1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Class1Test
    {
        [PexMethod]
        public bool Something([PexAssumeUnderTest]Class1 target, DateTime toTest)
        {
            MDateTime.NowGet = () => new DateTime(2000,1,1);
            bool result = target.Something(toTest);
            return result;
            // TODO: add assertions to method Class1Test.Something(Class1, DateTime)
        }
    }
}
