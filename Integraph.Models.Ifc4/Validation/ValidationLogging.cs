using Microsoft.Extensions.Logging;
using System;
using Integraph.Models.Common;

namespace Integraph.Models.Ifc4.Validation
{
    internal class ValidationLogging
    {
        internal static ILogger CreateLogger<T>()
        {
            return XbimLogging.CreateLogger<T>();
        }
    }
}