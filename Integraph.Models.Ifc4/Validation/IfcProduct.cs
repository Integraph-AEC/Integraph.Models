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
namespace Integraph.Models.Ifc4.Kernel
{
	public partial class IfcProduct : IExpressValidatable
	{
		public enum IfcProductClause
		{
			PlacementForShapeRepresentation,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcProductClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcProductClause.PlacementForShapeRepresentation:
						retVal = (Functions.EXISTS(Representation) && Functions.EXISTS(ObjectPlacement)) || (Functions.EXISTS(Representation) && (Functions.SIZEOF(Representation.Representations.Where(temp => Functions.TYPEOF(temp).Contains("IFC4.IFCSHAPEREPRESENTATION"))) == 0)) || (!(Functions.EXISTS(Representation)));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.Kernel.IfcProduct>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcProduct.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcProductClause.PlacementForShapeRepresentation))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcProduct.PlacementForShapeRepresentation", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
