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
	public partial class IfcRevolvedAreaSolid : IExpressValidatable
	{
		public enum IfcRevolvedAreaSolidClause
		{
			WR31,
			WR32,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRevolvedAreaSolidClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRevolvedAreaSolidClause.WR31:
						retVal = Axis.Location.Coordinates.ItemAt(2) == 0;
						break;
					case IfcRevolvedAreaSolidClause.WR32:
						retVal = Axis.Z.DirectionRatios().ItemAt(2) == 0;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometricModelResource.IfcRevolvedAreaSolid>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRevolvedAreaSolid.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcRevolvedAreaSolidClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRevolvedAreaSolid.WR31", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcRevolvedAreaSolidClause.WR32))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRevolvedAreaSolid.WR32", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
