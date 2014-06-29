using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class AbstractBaseClassTests
    {
        [TestMethod]
        public void Class_Inherits_AbstractBaseClass()
        {
            AssertClass<PublicClassWithAbstrctBaseClass>.InheritsAbstractBaseClass<PublicAbstractClass>();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void Class_Inherits_BaseClass_Fails()
        {
            AssertClass<PublicClassWithAbstrctBaseClass>.InheritsBaseClass<PublicClass>();
        }
    }
}