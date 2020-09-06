using System;
using System.Diagnostics;

namespace CG.Validations
{
    /// <summary>
    /// This class is a singleton implementation of the <see cref="IGuard"/>
    /// interface.
    /// </summary>
    public sealed class Guard : IGuard
    {
        // *******************************************************************
        // Fields.
        // *******************************************************************

        #region Fields

        /// <summary>
        /// This field contains the singleton instance.
        /// </summary>
        private static Guard _instance;

        #endregion

        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This method creates a new singleton instance of the 
        /// </summary>
        /// <returns>The singleton instance.</returns>
        [DebuggerStepThrough]
        public static Guard Instance()
        {
            // Should we create the singleton?
            if (_instance == null)
            {
                // Create the instance of T
                _instance = Activator.CreateInstance(typeof(Guard), true) as Guard;
            }

            // Return the instance.
            return _instance;
        }

        #endregion

        // *******************************************************************
        // Constructors.
        // *******************************************************************

        #region Constructors

        /// <summary>
        /// This constuctor creates a new instance of the <see cref="Guard"/>
        /// class.
        /// </summary>
        [DebuggerStepThrough]
        private Guard() { }

        #endregion
    }
}
