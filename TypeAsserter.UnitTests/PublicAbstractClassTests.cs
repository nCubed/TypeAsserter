using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class PublicAbstractClassTests
    {
        [TestMethod]
        public void PublicAbstractClass_IsPublic()
        {
            AssertClass<PublicAbstractClass>.IsPublic();
        }

        [TestMethod]
        public void PublicAbstractClass_IsAbstract()
        {
            AssertClass<PublicAbstractClass>.IsAbstract();
        }

        [TestMethod]
        public void PublicAbstractClass_IsNotSealed()
        {
            AssertClass<PublicAbstractClass>.IsNotSealed();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicAbstractClass_IsStatic_Fails()
        {
            AssertClass.IsStatic( typeof( PublicAbstractClass ), ClassVisibility.Public );
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicAbstractClass_IsInternal_Fails()
        {
            AssertClass<PublicAbstractClass>.IsInternal();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicAbstractClass_IsNotAbstract_Fails()
        {
            AssertClass<PublicAbstractClass>.IsNotAbstract();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicAbstractClass_IsSealed_Fails()
        {
            AssertClass<PublicAbstractClass>.IsSealed();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void PublicAbstractClass_Implements_INotImplementedInterface_Fails()
        {
            AssertClass<PublicAbstractClass>.ImplementsInterface<INotImplementedInterface>();
        }
    }
}