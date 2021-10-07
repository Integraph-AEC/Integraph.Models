using System;
using Microsoft.Extensions.Logging;
using Integraph.Models.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Integraph.Models.Common.Enumerations;
using Integraph.Models.Common.ExpressValidation;
using Integraph.Models.Ifc4.Interfaces;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Integraph.Models.Ifc4.PresentationAppearanceResource
{
	public partial struct IfcSpecularRoughness : IExpressValidatable
	{
		public enum IfcSpecularRoughnessClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcSpecularRoughnessClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcSpecularRoughnessClause.WR1:
						retVal = ((0 <= this) && (this <= 1) );
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.PresentationAppearanceResource.IfcSpecularRoughness>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcSpecularRoughness.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcSpecularRoughnessClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSpecularRoughness.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
