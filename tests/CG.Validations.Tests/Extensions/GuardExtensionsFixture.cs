
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CG.Validations
{
    /// <summary>
    /// This class is a test fixture for the <see cref="GuardExtensions"/>
    /// class.
    /// </summary>
    [TestClass]
    [TestCategory("Unit")]
    public class GuardExtensionsFixture
    {
        // *******************************************************************
        // Types.
        // *******************************************************************

        #region Types

        /// <summary>
        /// This class is for internal testing purposes
        /// </summary>
        class X
        {
            /// <summary>
            /// This property is for internal testing purposes
            /// </summary>
            public List<Y> ListY { get; set; } = new();
        }

        /// <summary>
        /// This class is for internal testing purposes
        /// </summary>
        class Y
        {
            /// <summary>
            /// This property is for internal testing purposes
            /// </summary>
            [Required]
            public string A { get; set; } = null!;
        }

        #endregion

        // *******************************************************************
        // Public methods.
        // *******************************************************************

        #region Public methods

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfInvalidObject(IGuard, object, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception when a 
        /// sub object has a decorated property with an invalid value.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfInvalidObject_ThrowFromInvalidSubOject()
        {
            var obj = new X();
            obj.ListY.Add(new Y());
            Guard.Instance().ThrowIfInvalidObject(obj, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfInvalidObject(IGuard, object, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input doesn't have any decorated properties to validate.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfInvalidObject_NoThrow()
        {
            Guard.Instance().ThrowIfInvalidObject(new object(), "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfNullOrEmpty(IGuard, string, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is a null or empty string.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfNullOrEmpty_ExpectThrow()
        {
            Guard.Instance().ThrowIfNullOrEmpty(null, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfNullOrEmpty(IGuard, string, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not a null or empty string.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfNullOrEmpty_ExpectNoThrow()
        {
            Guard.Instance().ThrowIfNullOrEmpty("test", "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfNull(IGuard, object, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GuardExtensions_ThrowIfNull_ExpectThrow()
        {
            Guard.Instance().ThrowIfNull(null, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfNull(IGuard, object, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not null.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfNull_ExpectNoThrow()
        {
            Guard.Instance().ThrowIfNull(new object(), "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanZero(IGuard, int, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is less than zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfLessThanZero_ExpectThrow()
        {
            int arg = -1;
            Guard.Instance().ThrowIfLessThanZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanZero(IGuard, int, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not less than zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfLessThanZero_ExpectNoThrow()
        {
            int arg = 1;
            Guard.Instance().ThrowIfLessThanZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanZero(IGuard, long, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is less than zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfLessThanZero_ExpectThrow2()
        {
            long arg = -1;
            Guard.Instance().ThrowIfLessThanZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanZero(IGuard, long, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not less than zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfLessThanZero_ExpectNoThrow2()
        {
            long arg = 1;
            Guard.Instance().ThrowIfLessThanZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfZero(IGuard, int, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfZero_ExpectThrow()
        {
            int arg = 0;
            Guard.Instance().ThrowIfZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfZero(IGuard, int, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfZero_ExpectNoThrow()
        {
            int arg = 1;
            Guard.Instance().ThrowIfZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfZero(IGuard, long, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfZero_ExpectThrow2()
        {
            long arg = 0;
            Guard.Instance().ThrowIfZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfZero(IGuard, long, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfZero_ExpectNoThrow2()
        {
            long arg = 1;
            Guard.Instance().ThrowIfZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfNotZero(IGuard, int, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is not zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfNotZero_ExpectThrow()
        {
            int arg = 2;
            Guard.Instance().ThrowIfNotZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfNotZero(IGuard, int, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfNotZero_ExpectNoThrow()
        {
            int arg = 0;
            Guard.Instance().ThrowIfNotZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfNotZero(IGuard, long, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is not zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfNotZero_ExpectThrow2()
        {
            long arg = 2;
            Guard.Instance().ThrowIfNotZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfNotZero(IGuard, long, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfNotZero_ExpectNoThrow2()
        {
            long arg = 0;
            Guard.Instance().ThrowIfNotZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, int, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is less than or equal to zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfLessThanOrEqualZero_ExpectThrow()
        {
            int arg = 0;
            Guard.Instance().ThrowIfLessThanOrEqualZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, int, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not less than or equal to zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfLessThanOrEqualZero_ExpectNoThrow()
        {
            int arg = 1;
            Guard.Instance().ThrowIfLessThanOrEqualZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, long, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is less than or equal to zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfLessThanOrEqualZero_ExpectThrow2()
        {
            long arg = 0;
            Guard.Instance().ThrowIfLessThanOrEqualZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, long, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not less than or equal to zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfLessThanOrEqualZero_ExpectNoThrow2()
        {
            long arg = 1;
            Guard.Instance().ThrowIfLessThanOrEqualZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, TimeSpan, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is less than or equal to zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfLessThanOrEqualZero_ExpectThrow3()
        {
            TimeSpan arg = TimeSpan.Zero;
            Guard.Instance().ThrowIfLessThanOrEqualZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, TimeSpan, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not less than or equal to zero.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfLessThanOrEqualZero_ExpectNoThrow3()
        {
            TimeSpan arg = TimeSpan.FromSeconds(1);
            Guard.Instance().ThrowIfLessThanOrEqualZero(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfTrue(IGuard, bool, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is true.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfTrue_ExpectThrow()
        {
            bool arg = true;
            Guard.Instance().ThrowIfTrue(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfTrue(IGuard, bool, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not true.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfTrue_ExpectNoThrow()
        {
            bool arg = false;
            Guard.Instance().ThrowIfTrue(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfFalse(IGuard, bool, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is false.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfFalse_ExpectThrow()
        {
            bool arg = false;
            Guard.Instance().ThrowIfFalse(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfFalse(IGuard, bool, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not false.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfFalse_ExpectNoThrow()
        {
            bool arg = true;
            Guard.Instance().ThrowIfFalse(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, int, int, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is less than a given number.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfLessThan_ExpectThrow()
        {
            int arg = 5;
            Guard.Instance().ThrowIfLessThan(arg, 10, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, int, int, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not less than a given number.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfLessThan_ExpectNoThrow()
        {
            int arg = 15;
            Guard.Instance().ThrowIfLessThan(arg, 10, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, long, long, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is less than a given number.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfLessThan_ExpectThrow2()
        {
            long arg = 5;
            Guard.Instance().ThrowIfLessThan(arg, 10, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, long, long, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not less than a given number.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfLessThan_ExpectNoThrow2()
        {
            long arg = 15;
            Guard.Instance().ThrowIfLessThan(arg, 10, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, TimeSpan, TimeSpan, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is less than a given timespan.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfLessThan_ExpectThrow3()
        {
            TimeSpan arg = TimeSpan.FromSeconds(5);
            Guard.Instance().ThrowIfLessThan(arg, TimeSpan.FromSeconds(10), "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, TimeSpan, TimeSpan, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not false.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfLessThan_ExpectNoThrow3()
        {
            TimeSpan arg = TimeSpan.FromSeconds(15);
            Guard.Instance().ThrowIfLessThan(arg, TimeSpan.FromSeconds(10), "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, int, int, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is greater than a given number.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfGreaterThan_ExpectThrow()
        {
            int arg = 10;
            Guard.Instance().ThrowIfGreaterThan(arg, 5, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, int, int, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not greater than a given number.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfGreaterThan_ExpectNoThrow()
        {
            int arg = 10;
            Guard.Instance().ThrowIfGreaterThan(arg, 15, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, long, long, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is greater than a given number.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfGreaterThan_ExpectThrow2()
        {
            long arg = 10;
            Guard.Instance().ThrowIfGreaterThan(arg, 5, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, long, long, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not greater than a given number.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfGreaterThan_ExpectNoThrow2()
        {
            long arg = 10;
            Guard.Instance().ThrowIfGreaterThan(arg, 15, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, TimeSpan, TimeSpan, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is greater than a given number.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfGreaterThan_ExpectThrow3()
        {
            TimeSpan arg = TimeSpan.FromSeconds(10);
            Guard.Instance().ThrowIfGreaterThan(arg, TimeSpan.FromSeconds(5), "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, TimeSpan, TimeSpan, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not greater than a given number.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfGreaterThan_ExpectNoThrow3()
        {
            TimeSpan arg = TimeSpan.FromSeconds(10);
            Guard.Instance().ThrowIfGreaterThan(arg, TimeSpan.FromSeconds(15), "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfEmptyGuid(IGuard, Guid, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is an empty guid.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfEmptyGuid_ExpectThrow3()
        {
            Guid arg = Guid.Empty;
            Guard.Instance().ThrowIfEmptyGuid(arg, "value");
        }


        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfEmptyGuid(IGuard, Guid, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not an empty guid.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfEmptyGuid_ExpectNoThrow3()
        {
            Guid arg = Guid.NewGuid();
            Guard.Instance().ThrowIfEmptyGuid(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfMalformedUri(IGuard, string, string, string, string, int)"/> 
        /// method. Here we verify that the method throws an exception if the 
        /// input is a malformed uri.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GuardExtensions_ThrowIfMalformedUri_ExpectThrow()
        {
            string arg = "http://www.contoso.com/path???/file name";
            Guard.Instance().ThrowIfMalformedUri(arg, "value");
        }

        // *******************************************************************

        /// <summary>
        /// This method is a unit test that verifies the <see cref="GuardExtensions.ThrowIfMalformedUri(IGuard, string, string, string, string, int)"/> 
        /// method. Here we verify that the method does not throw an exception 
        /// if the input is not a malformed uri.
        /// </summary>
        [TestMethod]
        public void GuardExtensions_ThrowIfMalformedUri_ExpectNoThrow()
        {
            string arg = "http://www.contoso.com/path/file+name";
            Guard.Instance().ThrowIfMalformedUri(arg, "value");
        }

        #endregion
    }
}
