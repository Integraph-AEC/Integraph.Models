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
namespace Integraph.Models.Ifc2x3.PresentationResource
{
	public partial struct IfcFontWeight : IExpressValidatable
	{
		public enum IfcFontWeightClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcFontWeightClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcFontWeightClause.WR1:
						retVal = Functions.NewArray("normal", "small-caps", "100", "200", "300", "400", "500", "600", "700", "800", "900").Contains(this);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.PresentationResource.IfcFontWeight>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcFontWeight.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcFontWeightClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFontWeight.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
