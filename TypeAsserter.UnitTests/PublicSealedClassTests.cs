using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class PublicSealedClassTests
    {
        [TestMethod]
        public void PublicSealedClass_IsPublic()
        {
            AssertClass<PublicSealedClass>.IsPublic();
        }

        [TestMethod]
        public void PublicSealedClass_IsNotAbstract()
        {
            AssertClass<PublicSealedClass>.IsNotAbstract();
        }

        [TestMethod]
        public void PublicSealedClass_IsSealed()
        {
            AssertClass<PublicSealedClass>.IsSealed();
        }

        [TestMethod]
        public void PublicSealedClass_Implements_IPublicInterface()
        {
            AssertClass<PublicSealedClass>.ImplementsInterface<IPublicInterface>();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicSealedClass_IsStatic_Fails()
        {
            AssertClass.IsStatic( typeof( PublicSealedClass ), ClassVisibility.Public );
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicSealedClass_IsInternal_Fails()
        {
            AssertClass<PublicSealedClass>.IsInternal();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicSealedClass_IsNotSealed_Fails()
        {
            AssertClass<PublicSealedClass>.IsNotSealed();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicSealedClass_IsAbstract_Fails()
        {
            AssertClass<PublicSealedClass>.IsAbstract();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicSealedClass_Implements_INotImplementedInterface_Fails()
        {
            AssertClass<PublicSealedClass>.ImplementsInterface<INotImplementedInterface>();
        }
    }
}