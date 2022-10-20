using CG.Core.Properties;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace CG.Validations
{
    /// <summary>
    /// This class contains extension methods related to the <see cref="IGuard"/>
    /// type.
    /// </summary>
    public static partial class GuardExtensions
    {
        // *******************************************************************
        // Public methods.
        // *******************************************************************

        #region Public methods

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument contains a null reference.
        /// </summary>
        /// <param name="guard">The guard instance to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> argument.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a null value.</exception>
        public static IGuard ThrowIfNull(
            this IGuard guard,
            object argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue == null)
            {
                // Panic!!!
                throw new ArgumentNullException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgNull,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/>
        /// argument contains a null reference or an empty string.
        /// </summary>
        /// <param name="guard">The guard instance to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> argument.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains an empty or null 
        /// string value.</exception>
        public static IGuard ThrowIfNullOrEmpty(
            this IGuard guard,
            string argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (string.IsNullOrEmpty(argValue))
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgNullOrEmpty,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument contains a value that is less than zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfLessThanZero(IGuard, int, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = -1;
        /// 
        ///         // throws an exception, since the argument is invalid.
        ///         Guard.Instance().ThrowIfLessThanZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfLessThanZero(
            this IGuard guard,
            int argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue < 0)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgLessThanZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument contains a value that is less than zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfLessThanZero(IGuard, long, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = -1L;
        /// 
        ///         // throws an exception, since the argument is invalid.
        ///         Guard.Instance().ThrowIfLessThanZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfLessThanZero(
            this IGuard guard,
            long argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue < 0)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgLessThanZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************


        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/>
        /// argument contains an empty time span value.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains an empty time 
        /// span value.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfZero(IGuard, TimeSpan, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = TimeSpan.Zero;
        /// 
        ///         // throws an exception, since the argument is invalid.
        ///         Guard.Instance().ThrowIfZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfZero(
            this IGuard guard,
            TimeSpan argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue == TimeSpan.Zero)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgIsZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/>
        /// argument contains an invalid DateTime value.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains an invalid value.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfInvalidDateTime(IGuard, DateTime, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = new DateTime();
        /// 
        ///         // throws an exception, since the argument is invalid.
        ///         Guard.Instance().ThrowIfInvalidDateTime(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfInvalidDateTime(
            this IGuard guard,
            DateTime argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (!DateTime.TryParse($"{argValue}", out _))
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgIsInvalidDateTime,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/>
        /// argument contains a FALSE value.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a FALSE value.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfFalse(IGuard, bool, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = false;
        /// 
        ///         // throws an exception, since the argument is false.
        ///         Guard.Instance().ThrowIfFalse(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfFalse(
            this IGuard guard,
            bool argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (!argValue)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgIsFalse,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/>
        /// argument contains a TRUE value.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a FALSE value.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfTrue(IGuard, bool, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = true;
        /// 
        ///         // throws an exception, since the argument is true.
        ///         Guard.Instance().ThrowIfTrue(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfTrue(
            this IGuard guard,
            bool argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgIsTrue,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/>
        /// argument contains a value that is less than or equal to zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than or equal to zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, int, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 0;
        /// 
        ///         // throws an exception, since the argument is less than or equal to zero.
        ///         Guard.Instance().ThrowIfLessThanOrEqualZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfLessThanOrEqualZero(
            this IGuard guard,
            int argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue <= 0)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgLessThanEqualZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the '<paramref name="argValue"/>
        /// argument contains a value that is less than or equal to zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than or equal to zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, long, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 0;
        /// 
        ///         // throws an exception, since the argument is less than or equal to zero.
        ///         Guard.Instance().ThrowIfLessThanOrEqualZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfLessThanOrEqualZero(
            this IGuard guard,
            long argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue <= 0)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgLessThanEqualZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an <see cref="ArgumentException"/> if the value
        /// of the <paramref name="argValue"/> parameter has a value less than
        /// or equal to zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> argument.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than, or equal to zero.</exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfLessThanOrEqualZero(IGuard, TimeSpan, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = Timespan.Zero;
        /// 
        ///         // throws an exception, since the argument is less than or equal to zero.
        ///         Guard.Instance().ThrowIfLessThanOrEqualZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfLessThanOrEqualZero(
            this IGuard guard,
            TimeSpan argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue <= TimeSpan.Zero)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgLessThanEqualZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method will throw an exception if the <paramref name="argValue"/>
        /// argument is less than the <paramref name="amount"/> argument.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to be validated.</param>
        /// <param name="amount">The amount to be used for validation.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than the <paramref name="amount"/> argument.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, int, int, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 1;
        /// 
        ///         // make the value to compare it against.
        ///         var amount = 2; 
        /// 
        ///         // throws an exception, since the argument is less than 2.
        ///         Guard.Instance().ThrowIfLessThan(arg, amount, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfLessThan(
            this IGuard guard,
            int argValue,
            int amount,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue < amount)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgLessThan,
                        amount,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method will throw an exception if the <paramref name="argValue"/>
        /// argument is less than the <paramref name="amount"/> argument.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to be validated.</param>
        /// <param name="amount">The amount to be used for validation.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than the <paramref name="amount"/> argument.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, long, long, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 1;
        /// 
        ///         // make the value to compare it against.
        ///         var amount = 2; 
        /// 
        ///         // throws an exception, since the argument is less than 2.
        ///         Guard.Instance().ThrowIfLessThan(arg, amount, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfLessThan(
            this IGuard guard,
            long argValue,
            long amount,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue < amount)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgLessThan,
                        amount,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method will throw an exception if the <paramref name="argValue"/>
        /// argument is less than the <paramref name="amount"/> argument.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to be validated.</param>
        /// <param name="amount">The amount to be used for validation.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than the <paramref name="amount"/> argument.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfLessThan(IGuard, TimeSpan, TimeSpan, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = new timeSpan(1, 1, 1);
        /// 
        ///         // make the value to compare it against.
        ///         var amount = new TimeSpan(2, 2, 2); 
        /// 
        ///         // throws an exception, since the argument is less than 2:2:2.
        ///         Guard.Instance().ThrowIfLessThan(arg, amount, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfLessThan(
            this IGuard guard,
            TimeSpan argValue,
            TimeSpan amount,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue < amount)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgLessThan,
                        amount,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method will throw an exception if the <paramref name="argValue"/> 
        /// argument is greater than the <paramref name="amount"/> argument. 
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to be validated.</param>
        /// <param name="amount">The amount to be used for validation.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// greater than the <paramref name="amount"/> argument.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, int, int, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 2;
        /// 
        ///         // make the value to compare it against.
        ///         var amount = 1; 
        /// 
        ///         // throws an exception, since the argument is greater than 1.
        ///         Guard.Instance().ThrowIfGreaterThan(arg, amount, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfGreaterThan(
            this IGuard guard,
            int argValue,
            int amount,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue > amount)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgGreaterThan,
                        amount,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method will throw an exception if the <paramref name="argValue"/> 
        /// argument is greater than the <paramref name="amount"/> argument. 
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to be validated.</param>
        /// <param name="amount">The amount to be used for validation.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// greater than the <paramref name="amount"/> argument.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, long, long, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 2;
        /// 
        ///         // make the value to compare it against.
        ///         var amount = 1; 
        /// 
        ///         // throws an exception, since the argument is greater than 1.
        ///         Guard.Instance().ThrowIfGreaterThan(arg, amount, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfGreaterThan(
            this IGuard guard,
            long argValue,
            long amount,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue > amount)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgGreaterThan,
                        amount,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method will throw an exception if the <paramref name="argValue"/> 
        /// argument is greater than the <paramref name="amount"/> argument. 
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to be validated.</param>
        /// <param name="amount">The amount to be used for validation.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// greater than the <paramref name="amount"/> argument.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfGreaterThan(IGuard, TimeSpan, TimeSpan, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = new TimeSpan(1, 1, 1);
        /// 
        ///         // make the value to compare it against.
        ///         var amount = new TimeSpan(1, 1, 1); 
        /// 
        ///         // throws an exception, since the argument is greater than 1.
        ///         Guard.Instance().ThrowIfGreaterThan(arg, amount, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfGreaterThan(
            this IGuard guard,
            TimeSpan argValue,
            TimeSpan amount,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue > amount)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgGreaterThan,
                        amount,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument contains a zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfZero(IGuard, int, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 0;
        /// 
        ///         // throws an exception, since the argument is zero.
        ///         Guard.Instance().ThrowIfZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfZero(
            this IGuard guard,
            int argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue == 0)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument contains a zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfZero(IGuard, long, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 0;
        /// 
        ///         // throws an exception, since the argument is zero.
        ///         Guard.Instance().ThrowIfZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfZero(
            this IGuard guard,
            long argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue == 0)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument contains something other than zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// something other than zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfZero(IGuard, long, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 1;
        /// 
        ///         // throws an exception, since the argument is not zero.
        ///         Guard.Instance().ThrowIfNotZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfNotZero(
            this IGuard guard,
            long argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue != 0)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgNotZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument contains something other than zero.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// something other than zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfNotZero(IGuard, int, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 1;
        /// 
        ///         // throws an exception, since the argument is not zero.
        ///         Guard.Instance().ThrowIfNotZero(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfNotZero(
            this IGuard guard,
            int argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue != 0)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgNotZero,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/>
        /// argument does not contain a null reference or an empty string.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument does not contain an empty 
        /// or null string value.</exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfNotNullOrEmpty(IGuard, string, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = "testing, 1, 2, 3";
        /// 
        ///         // throws an exception, since the string not null or empty.
        ///         Guard.Instance().ThrowIfNotNullOrEmpty(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfNotNullOrEmpty(
            this IGuard guard,
            string argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (!string.IsNullOrEmpty(argValue))
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgNotNullOrEmpty,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument contains an empty GUID instance.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains an empty GUID.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfEmptyGuid(IGuard, Guid, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = Guid.Empty;
        /// 
        ///         // throws an exception, since the GUID is empty.
        ///         Guard.Intance().ThrowIfEmptyGuid(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfEmptyGuid(
            this IGuard guard,
            Guid argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue == Guid.Empty)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_EmptyGuid,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // ******************************************************************

        /// <summary>
        /// This method throws an exception if the <paramref name="argValue"/> 
        /// argument does not contain an empty GUID instance.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument does not contain an 
        /// empty GUID.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfNotEmptyGuid(IGuard, Guid, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = Guid.Parse("some guid value");
        /// 
        ///         // throws an exception, since the GUID is not empty.
        ///         Guard.Instance().ThrowIfNotEmptyGuid(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfNotEmptyGuid(
            this IGuard guard,
            Guid argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue != Guid.Empty)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_NotEmptyGuid,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the "argValue" argument 
        /// contains a malformed URI.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a malformed uri.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="GuardExtensions.ThrowIfMalformedUri(IGuard, string, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = "*";
        /// 
        ///         // throws an exception, since the URI is malformed.
        ///         Guard.Instance().ThrowIfMalformedUri(arg, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfMalformedUri(
            this IGuard guard,
            string argValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (!Uri.IsWellFormedUriString(argValue, UriKind.RelativeOrAbsolute))
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_MalformedUri,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the '<paramref name="argValue"/>
        /// argument contains a value that is equal to the <paramref name="compareValue"/>
        /// parameter.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="compareValue">The comparison value.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than or equal to zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="ThrowIfEqual(IGuard, long, long, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 0;
        /// 
        ///         // throws an exception, since the argument is equal.
        ///         Guard.Instance().ThrowIfEqual(arg, 0, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfEqual(
            this IGuard guard,
            long argValue,
            long compareValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue == compareValue)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgEqual,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the '<paramref name="argValue"/>
        /// argument contains a value that is equal to the <paramref name="compareValue"/>
        /// parameter.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="compareValue">The comparison value.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than or equal to zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="ThrowIfEqual(IGuard, int, int, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 0;
        /// 
        ///         // throws an exception, since the argument is equal.
        ///         Guard.Instance().ThrowIfEqual(arg, 0, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfEqual(
            this IGuard guard,
            int argValue,
            int compareValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue == compareValue)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgEqual,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the '<paramref name="argValue"/>
        /// argument contains a value that is not equal to the <paramref name="compareValue"/>
        /// parameter.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="compareValue">The comparison value.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than or equal to zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="ThrowIfNotEqual(IGuard, long, long, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 0;
        /// 
        ///         // throws an exception, since the argument is not equal.
        ///         Guard.Instance().ThrowIfNotEqual(arg, 1, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfNotEqual(
            this IGuard guard,
            long argValue,
            long compareValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue != compareValue)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgNotEqual,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        // *******************************************************************

        /// <summary>
        /// This method throws an exception if the '<paramref name="argValue"/>
        /// argument contains a value that is not equal to the <paramref name="compareValue"/>
        /// parameter.
        /// </summary>
        /// <param name="guard">The guard to use for the operation.</param>
        /// <param name="argValue">The argument to test.</param>
        /// <param name="compareValue">The comparison value.</param>
        /// <param name="argName">The name of the argument.</param>
        /// <param name="memberName">Not used. Supplied by the compiler.</param>
        /// <param name="sourceFilePath">Not used. Supplied by the compiler.</param>
        /// <param name="sourceLineNumber">Not used. Supplied by the compiler.</param>
        /// <returns>The <paramref name="guard"/> value.</returns>
        /// <exception cref="ArgumentException">This exception is thrown when
        /// the <paramref name="argValue"/> argument contains a value that is
        /// less than or equal to zero.
        /// </exception>
        /// <example>
        /// This example shows how to call the <see cref="ThrowIfNotEqual(IGuard, int, int, string, string, string, int)"/>
        /// method.
        /// <code>
        /// class TestClass
        /// {
        ///     static void Main()
        ///     {
        ///         // make an invalid argument.
        ///         var arg = 0;
        /// 
        ///         // throws an exception, since the argument is not equal.
        ///         Guard.Instance().ThrowIfNotEqual(arg, 1, nameof(arg));
        ///     }
        /// }
        /// </code>
        /// </example>
        public static IGuard ThrowIfNotEqual(
            this IGuard guard,
            int argValue,
            int compareValue,
            string argName,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0
            )
        {
            // Make the test.
            if (argValue != compareValue)
            {
                // Panic!!!
                throw new ArgumentException(
                    message: string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Guard_ArgNotEqual,
                        memberName,
                        sourceFilePath,
                        sourceLineNumber
                        ),
                    paramName: argName
                    );
            }

            // Return the guard.
            return guard;
        }

        #endregion
    }
}
