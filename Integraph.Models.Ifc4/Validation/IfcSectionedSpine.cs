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
namespace Integraph.Models.Ifc4.GeometricModelResource
{
	public partial class IfcSectionedSpine : IExpressValidatable
	{
		public enum IfcSectionedSpineClause
		{
			CorrespondingSectionPositions,
			ConsistentProfileTypes,
			SpineCurveDim,
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
					case IfcSectionedSpineClause.CorrespondingSectionPositions:
						retVal = Functions.SIZEOF(CrossSections) == Functions.SIZEOF(CrossSectionPositions);
						break;
					case IfcSectionedSpineClause.ConsistentProfileTypes:
						retVal = Functions.SIZEOF(CrossSections.Where(temp => CrossSections.ItemAt(0).ProfileType != temp.ProfileType)) == 0;
						break;
					case IfcSectionedSpineClause.SpineCurveDim:
						retVal = SpineCurve.Dim == 3;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometricModelResource.IfcSectionedSpine>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcSectionedSpine.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcSectionedSpineClause.CorrespondingSectionPositions))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSectionedSpine.CorrespondingSectionPositions", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcSectionedSpineClause.ConsistentProfileTypes))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSectionedSpine.ConsistentProfileTypes", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcSectionedSpineClause.SpineCurveDim))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSectionedSpine.SpineCurveDim", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
