using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeAsserter.UnitTests.Mocks;

namespace TypeAsserter.UnitTests
{
    [TestClass]
    public class InternalClassTests
    {
        [TestMethod]
        public void InternalClass_IsInternal()
        {
            AssertClass<InternalClass>.IsInternal();
        }

        [TestMethod]
        public void InternalClass_Implements_IPublicInterface()
        {
            AssertClass<InternalClass>.ImplementsInterface<IInternalInterface>();
        }

        [TestMethod]
        public void InternalClass_IsNotAbstract()
        {
            AssertClass<InternalClass>.IsNotAbstract();
        }

        [TestMethod]
        public void InternalClass_IsNotSealed()
        {
            AssertClass<InternalClass>.IsNotSealed();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void InternalClass_IsStatic_Fails()
        {
            AssertClass.IsStatic( typeof( InternalClass ), ClassVisibility.Public );
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void InternalClass_IsPublic_Fails()
        {
            AssertClass<InternalClass>.IsPublic();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void InternalClass_IsSealed_Fails()
        {
            AssertClass<InternalClass>.IsSealed();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void InternalClass_IsAbstract_Fails()
        {
            AssertClass<InternalClass>.IsAbstract();
        }

        [TestMethod]
        [ExpectedException( typeof( AssertFailedException ) )]
        public void InternalClass_Implements_INotImplementedInterface_Fails()
        {
            AssertClass<InternalClass>.ImplementsInterface<INotImplementedInterface>();
        }
    }
}