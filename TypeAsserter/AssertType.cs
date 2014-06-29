using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeAsserter
{
    /// <summary>
    /// Verifies conditions about a <see cref="Type"/> in unit tests.
    /// </summary>
    public static class AssertType
    {
        /// <summary>
        /// Asserts the specified <paramref name="type"/> is public.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to test.</param>
        public static void IsPublic( Type type )
        {
            bool isPublic = type.IsPublic;

            Assert.IsTrue( isPublic );
        }

        /// <summary>
        /// Asserts the specified <paramref name="type"/> is internal.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to test.</param>
        public static void IsInternal( Type type )
        {
            bool isInternal = type.IsNotPublic;

            Assert.IsTrue( isInternal );
        }

        /// <summary>
        /// Asserts the specified <paramref name="type"/> is abstract.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to test.</param>
        public static void IsAbstract( Type type )
        {
            bool isAbstract = type.IsAbstract;

            Assert.IsTrue( isAbstract );
        }

        /// <summary>
        /// Asserts the specified <paramref name="type"/> is not abstract.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to test.</param>
        public static void IsNotAbstract( Type type )
        {
            bool isAbstract = type.IsAbstract;

            Assert.IsFalse( isAbstract );
        }

        /// <summary>
        /// Asserts the specified <paramref name="type"/> is sealed.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to test.</param>
        public static void IsSealed( Type type )
        {
            bool isSealed = type.IsSealed;

            Assert.IsTrue( isSealed );
        }

        /// <summary>
        /// Asserts the specified <paramref name="type"/> is not sealed.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to test.</param>
        public static void IsNotSealed( Type type )
        {
            bool isSealed = type.IsSealed;

            Assert.IsFalse( isSealed );
        }

        /// <summary>
        /// Asserts the specified <paramref name="type"/> is an interface.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to test.</param>
        public static void IsInterface( Type type )
        {
            bool isInterface = type.IsInterface;

            Assert.IsTrue( isInterface );
        }

        internal static void Visibility( Type type, ClassVisbility visbility )
        {
            switch( visbility )
            {
                case ClassVisbility.Public:
                    IsPublic( type );
                    break;

                case ClassVisbility.Internal:
                    IsInternal( type );
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}