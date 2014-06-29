using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class PublicClassTests
    {
        [TestMethod]
        public void PublicClass_IsPublic()
        {
            AssertClass<PublicClass>.IsPublic();
        }

        [TestMethod]
        public void PublicClass_IsNotAbstract()
        {
            AssertClass<PublicClass>.IsNotAbstract();
        }

        [TestMethod]
        public void PublicClass_IsNotSealed()
        {
            AssertClass<PublicClass>.IsNotSealed();
        }

        [TestMethod]
        public void PublicClass_Implements_IPublicInterface()
        {
            AssertClass<PublicClass>.ImplementsInterface<IPublicInterface>();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicClass_IsStatic_Fails()
        {
            AssertClass.IsStatic( typeof( PublicClass ), ClassVisibility.Public );
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicClass_IsInternal_Fails()
        {
            AssertClass<PublicClass>.IsInternal();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicClass_IsSealed_Fails()
        {
            AssertClass<PublicClass>.IsSealed();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicClass_IsAbstract_Fails()
        {
            AssertClass<PublicClass>.IsAbstract();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicClass_Implements_INotImplementedInterface_Fails()
        {
            AssertClass<PublicClass>.ImplementsInterface<INotImplementedInterface>();
        }
    }
}
