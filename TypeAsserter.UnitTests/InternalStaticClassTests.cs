using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class InternalStaticClassTests
    {
        [TestMethod]
        public void InternalStaticClass_IsStatic()
        {
            AssertClass.IsStatic( typeof( InternalStaticClass ), ClassVisibility.Internal );
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void InternalStaticClass_IsStatic_PublicVisibilty_Fails()
        {
            AssertClass.IsStatic( typeof( InternalStaticClass ), ClassVisibility.Public );
        }
    }
}