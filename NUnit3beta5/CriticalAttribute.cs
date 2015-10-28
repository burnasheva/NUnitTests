using System;
using NUnit.Framework;

namespace NUnit3beta5
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    class CriticalAttribute : CategoryAttribute { }
    
}
