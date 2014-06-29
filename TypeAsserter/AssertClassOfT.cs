using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeAsserter
{
    /// <summary>
    /// Verifies conditions about a class in unit tests.
    /// </summary>
    /// <typeparam name="TClass">The type of class to be tested.</typeparam>
    public static class AssertClass<TClass> where TClass : class
    {
        /// <summary>
        /// Asserts the specified <see cref="TClass"/> is internal.
        /// </summary>
        public static void IsInternal()
        {
            Type t = typeof( TClass );

            AssertType.IsInternal( t );
        }

        /// <summary>
        /// Asserts the specified <see cref="TClass"/> is public.
        /// </summary>
        public static void IsPublic()
        {
            Type t = typeof( TClass );

            AssertType.IsPublic( t );
        }

        /// <summary>
        /// Asserts the specified <see cref="TClass"/> is abstract.
        /// </summary>
        public static void IsAbstract()
        {
            Type t = typeof( TClass );

            AssertType.IsAbstract( t );
        }

        /// <summary>
        /// Asserts the specified <see cref="TClass"/> is not abstract.
        /// </summary>
        public static void IsNotAbstract()
        {
            Type t = typeof( TClass );

            AssertType.IsNotAbstract( t );
        }

        /// <summary>
        /// Asserts the specified <see cref="TClass"/> is sealed.
        /// </summary>
        public static void IsSealed()
        {
            Type t = typeof( TClass );

            AssertType.IsSealed( t );
        }

        /// <summary>
        /// Asserts the specified <see cref="TClass"/> is not sealed.
        /// </summary>
        public static void IsNotSealed()
        {
            Type t = typeof( TClass );

            AssertType.IsNotSealed( t );
        }

        /// <summary>
        /// Asserts the specified <see cref="TClass"/> inherits a base class.
        /// The <typeparamref name="TBaseClass"/> is expected to not be abstract.
        /// Use the <see cref="InheritsAbstractBaseClass{TBaseClass}"/> method if
        /// the expected base class is abstract.
        /// </summary>
        /// <typeparam name="TBaseClass">The base class type.</typeparam>
        public static void InheritsBaseClass<TBaseClass>() where TBaseClass : class
        { 
            Type baseType = typeof( TBaseClass );

            AssertType.IsNotAbstract( baseType );

            AssertIsAssignableFrom( baseType );
        }

        /// <summary>
        /// Asserts the specified <see cref="TClass"/> inherits an abstract base class.
        /// The <typeparamref name="TAbstractClass"/> is expected to be abstract.
        /// Use the <see cref="InheritsBaseClass{TBaseClass}"/> method if the
        /// expected base class is not abstract.
        /// </summary>
        /// <typeparam name="TAbstractClass">The abstract base class type.</typeparam>
        public static void InheritsAbstractBaseClass<TAbstractClass>() where TAbstractClass : class
        {
            Type abstractType = typeof( TAbstractClass );

            AssertType.IsAbstract( abstractType );

            AssertIsAssignableFrom( abstractType );
        }

        /// <summary>
        /// Asserts the specified <see cref="TClass"/> implements an interface.
        /// </summary>
        /// <typeparam name="TInterface">The expected interface.</typeparam>
        public static void ImplementsInterface<TInterface>() where TInterface : class
        {
            Type interfaceType = typeof( TInterface );

            AssertType.IsInterface( interfaceType );

            AssertIsAssignableFrom( interfaceType );
        }

        private static void AssertIsAssignableFrom( Type assignableType )
        {
            Type classType = typeof( TClass );

            bool isAssignableFrom = assignableType.IsAssignableFrom( classType );

            Assert.IsTrue( isAssignableFrom );
        }
    }
}
