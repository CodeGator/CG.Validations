using System;

namespace CG.Validations.QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the guard type is easy, start with a call to Guard.Instance(),
            //   which references the singletone instance of the Guard type, and 
            //   returns an IGuard instance. From there, many extension methods exist
            //   to validate parameters in various ways. For instance:

            var boolParm = true;
            Guard.Instance().ThrowIfFalse(boolParm, nameof(boolParm));

            // Or ...

            var guidParm = Guid.NewGuid();
            Guard.Instance().ThrowIfEmptyGuid(guidParm, nameof(guidParm));

            // Or ...

            var stringParm = "hi there";
            Guard.Instance().ThrowIfNullOrEmpty(stringParm, nameof(stringParm));

            // Have fun!
        }
    }
}
