using System.Collections.Generic;

namespace Integraph.Models.Common.ExpressValidation
{
    public interface IExpressValidatable
    {
        IEnumerable<ValidationResult> Validate();
    }
}
