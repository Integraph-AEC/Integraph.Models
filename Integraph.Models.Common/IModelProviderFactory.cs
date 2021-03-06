
using System;

namespace Integraph.Models.IO
{
    /// <summary>
    /// Factory to create an appropriate 
    /// </summary>
    public interface IModelProviderFactory
    {
        IModelProvider CreateProvider();
        void Use(Func<IModelProvider> providerFn);
    }
}
