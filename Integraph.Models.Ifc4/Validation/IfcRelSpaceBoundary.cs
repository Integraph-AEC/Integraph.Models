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
namespace Integraph.Models.Ifc4.ProductExtension
{
	public partial class IfcRelSpaceBoundary : IExpressValidatable
	{
		public enum IfcRelSpaceBoundaryClause
		{
			CorrectPhysOrVirt,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRelSpaceBoundaryClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRelSpaceBoundaryClause.CorrectPhysOrVirt:
						retVal = ((PhysicalOrVirtualBoundary == IfcPhysicalOrVirtualEnum.PHYSICAL) && (!(Functions.TYPEOF(RelatedBuildingElement).Contains("IFC4.IFCVIRTUALELEMENT")))) || ((PhysicalOrVirtualBoundary == IfcPhysicalOrVirtualEnum.VIRTUAL) && ((Functions.TYPEOF(RelatedBuildingElement).Contains("IFC4.IFCVIRTUALELEMENT")) || (Functions.TYPEOF(RelatedBuildingElement).Contains("IFC4.IFCOPENINGELEMENT")))) || (PhysicalOrVirtualBoundary == IfcPhysicalOrVirtualEnum.NOTDEFINED);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProductExtension.IfcRelSpaceBoundary>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRelSpaceBoundary.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcRelSpaceBoundaryClause.CorrectPhysOrVirt))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelSpaceBoundary.CorrectPhysOrVirt", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
