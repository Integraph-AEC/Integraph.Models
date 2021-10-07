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
namespace Integraph.Models.Ifc2x3.StructuralAnalysisDomain
{
	public partial class IfcStructuralSurfaceMemberVarying : IExpressValidatable
	{
		public enum IfcStructuralSurfaceMemberVaryingClause
		{
			WR61,
			WR62,
			WR63,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcStructuralSurfaceMemberVaryingClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcStructuralSurfaceMemberVaryingClause.WR61:
						retVal = Functions.EXISTS(this/* as IfcStructuralSurfaceMember*/.Thickness);
						break;
					case IfcStructuralSurfaceMemberVaryingClause.WR62:
						retVal = Functions.SIZEOF(this.VaryingThicknessLocation.ShapeRepresentations.Where(temp => !(Functions.SIZEOF(temp/* as IfcRepresentation*/.Items) == 1))) == 0;
						break;
					case IfcStructuralSurfaceMemberVaryingClause.WR63:
						retVal = Functions.SIZEOF(this.VaryingThicknessLocation.ShapeRepresentations.Where(temp => !((Functions.TYPEOF(temp/* as IfcRepresentation*/.Items.ItemAt(0)).Contains("IFC2X3.IFCCARTESIANPOINT")) || (Functions.TYPEOF(temp/* as IfcRepresentation*/.Items.ItemAt(0)).Contains("IFC2X3.IFCPOINTONSURFACE"))))) == 0;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.StructuralAnalysisDomain.IfcStructuralSurfaceMemberVarying>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcStructuralSurfaceMemberVarying.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcStructuralSurfaceMemberVaryingClause.WR61))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralSurfaceMemberVarying.WR61", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcStructuralSurfaceMemberVaryingClause.WR62))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralSurfaceMemberVarying.WR62", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcStructuralSurfaceMemberVaryingClause.WR63))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralSurfaceMemberVarying.WR63", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
