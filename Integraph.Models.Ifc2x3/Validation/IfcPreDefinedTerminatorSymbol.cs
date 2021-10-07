using System;
using Microsoft.Extensions.Logging;
using Integraph.Models.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Integraph.Models.Common.Enumerations;
using Integraph.Models.Common.ExpressValidation;
using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.ProfileResource;
using Integraph.Models.Ifc2x3.ProfilePropertyResource;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Integraph.Models.Ifc2x3.PresentationDimensioningResource
{
	public partial class IfcPreDefinedTerminatorSymbol : IExpressValidatable
	{
		public enum IfcPreDefinedTerminatorSymbolClause
		{
			WR31,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPreDefinedTerminatorSymbolClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPreDefinedTerminatorSymbolClause.WR31:
						retVal = Functions.NewArray("blanked arrow", "blanked box", "blanked dot", "dimension origin", "filled arrow", "filled box", "filled dot", "integral symbol", "open arrow", "slash", "unfilled arrow").Contains(this/* as IfcPreDefinedItem*/.Name);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.PresentationDimensioningResource.IfcPreDefinedTerminatorSymbol>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPreDefinedTerminatorSymbol.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPreDefinedTerminatorSymbolClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPreDefinedTerminatorSymbol.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
