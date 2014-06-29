using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class InterfaceTests
    {
        [TestMethod]
        public void IPublicInterface_IsPublic()
        {
            AssertClass<IPublicInterface>.IsPublic();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void IPublicInterface_IsInternal_Fails()
        {
            AssertClass<IPublicInterface>.IsInternal();
        }

        [TestMethod]
        public void IInternalInterface_IsInternal()
        {
            AssertClass<IInternalInterface>.IsInternal();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void IInternalInterface_IsPublic_Fails()
        {
            AssertClass<IInternalInterface>.IsPublic();
        }
    }
}