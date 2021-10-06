using System.Collections.Generic;

namespace Integraph.Models.Common
{
    public interface IContainsEntityReferences: IPersistEntity
    {
        IEnumerable<IPersistEntity> References { get; } 
    }
}
