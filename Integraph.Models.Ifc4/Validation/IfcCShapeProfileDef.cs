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
namespace Integraph.Models.Ifc4.ProfileResource
{
	public partial class IfcCShapeProfileDef : IExpressValidatable
	{
		public enum IfcCShapeProfileDefClause
		{
			ValidGirth,
			ValidInternalFilletRadius,
			ValidWallThickness,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcCShapeProfileDefClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcCShapeProfileDefClause.ValidGirth:
						retVal = Girth < (Depth / 2);
						break;
					case IfcCShapeProfileDefClause.ValidInternalFilletRadius:
						retVal = !(Functions.EXISTS(InternalFilletRadius)) || ((InternalFilletRadius <= Width / 2 - WallThickness) && (InternalFilletRadius <= Depth / 2 - WallThickness));
						break;
					case IfcCShapeProfileDefClause.ValidWallThickness:
						retVal = (WallThickness < Width / 2) && (WallThickness < Depth / 2);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProfileResource.IfcCShapeProfileDef>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcCShapeProfileDef.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcCShapeProfileDefClause.ValidGirth))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCShapeProfileDef.ValidGirth", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCShapeProfileDefClause.ValidInternalFilletRadius))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCShapeProfileDef.ValidInternalFilletRadius", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCShapeProfileDefClause.ValidWallThickness))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCShapeProfileDef.ValidWallThickness", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
