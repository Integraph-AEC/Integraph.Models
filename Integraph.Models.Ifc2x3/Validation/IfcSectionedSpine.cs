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
namespace Integraph.Models.Ifc2x3.GeometricModelResource
{
	public partial class IfcSectionedSpine : IExpressValidatable
	{
		public enum IfcSectionedSpineClause
		{
			WR1,
			WR2,
			WR3,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcSectionedSpineClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcSectionedSpineClause.WR1:
						retVal = Functions.SIZEOF(CrossSections) == Functions.SIZEOF(CrossSectionPositions);
						break;
					case IfcSectionedSpineClause.WR2:
						retVal = Functions.SIZEOF(CrossSections.Where(temp => CrossSections.ItemAt(0).ProfileType != temp.ProfileType)) == 0;
						break;
					case IfcSectionedSpineClause.WR3:
						retVal = SpineCurve.Dim == 3;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometricModelResource.IfcSectionedSpine>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcSectionedSpine.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcSectionedSpineClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSectionedSpine.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcSectionedSpineClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSectionedSpine.WR2", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcSectionedSpineClause.WR3))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSectionedSpine.WR3", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
