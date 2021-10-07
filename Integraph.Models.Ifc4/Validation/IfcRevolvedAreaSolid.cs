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
	public partial class IfcRevolvedAreaSolid : IExpressValidatable
	{
		public enum IfcRevolvedAreaSolidClause
		{
			AxisStartInXY,
			AxisDirectionInXY,
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
					case IfcRevolvedAreaSolidClause.AxisStartInXY:
						retVal = Axis.Location.Coordinates.ItemAt(2) == 0;
						break;
					case IfcRevolvedAreaSolidClause.AxisDirectionInXY:
						retVal = Axis.Z.DirectionRatios().ItemAt(2) == 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometricModelResource.IfcRevolvedAreaSolid>();
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
			if (!ValidateClause(IfcRevolvedAreaSolidClause.AxisStartInXY))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRevolvedAreaSolid.AxisStartInXY", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcRevolvedAreaSolidClause.AxisDirectionInXY))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRevolvedAreaSolid.AxisDirectionInXY", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
