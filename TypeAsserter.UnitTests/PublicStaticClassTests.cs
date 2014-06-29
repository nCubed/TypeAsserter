using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class PublicStaticClassTests
    {
        [TestMethod]
        public void PublicStaticClass_IsStatic()
        {
            AssertClass.IsStatic( typeof( PublicStaticClass ), ClassVisibility.Public );
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicStaticClass_IsStatic_InternalVisibilty_Fails()
        {
            AssertClass.IsStatic( typeof( PublicStaticClass ), ClassVisibility.Internal );
        }
    }
}