using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class BaseClassTests
    {
        [TestMethod]
        public void Class_Inherits_BaseClass()
        {
            AssertClass<PublicClassWithBaseClass>.InheritsBaseClass<PublicClass>();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void Class_Inherits_AbstractBaseClass_Fails()
        {
            AssertClass<PublicClassWithBaseClass>.InheritsAbstractBaseClass<PublicAbstractClass>();
        }
    }
}