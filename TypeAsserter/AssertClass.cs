using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeAsserter
{
    /// <summary>
    /// Verifies conditions about a class in unit tests.
    /// </summary>
    public static class AssertClass
    {
        /// <summary>
        /// Verifies that the specified class is static.
        /// </summary>
        /// <param name="type">the type of class.</param>
        /// <param name="visibility">the expected visibility of the class.</param>
        public static void IsStatic( Type type, ClassVisibility visibility )
        {
            bool isStatic = type.IsAbstract && type.IsSealed;

            Assert.IsTrue( isStatic );

            ConstructorInfo[] ctors = type.GetConstructors( BindingFlags.Public );

            Assert.AreEqual( 0, ctors.Length );

            AssertType.Visibility( type, visibility );
        }
    }
}