using System.Collections.Generic;

namespace Integraph.Models.Common
{
    public interface IContainsIndexedReferences: IPersistEntity
    {
        IEnumerable<IPersistEntity> IndexedReferences { get; }
    }
}
