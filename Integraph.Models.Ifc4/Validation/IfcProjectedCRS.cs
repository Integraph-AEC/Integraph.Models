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
namespace Integraph.Models.Ifc4.RepresentationResource
{
	public partial class IfcProjectedCRS : IExpressValidatable
	{
		public enum IfcProjectedCRSClause
		{
			IsLengthUnit,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcProjectedCRSClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcProjectedCRSClause.IsLengthUnit:
						retVal = !(Functions.EXISTS(MapUnit)) || (MapUnit.UnitType == IfcUnitEnum.LENGTHUNIT);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.RepresentationResource.IfcProjectedCRS>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcProjectedCRS.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcProjectedCRSClause.IsLengthUnit))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcProjectedCRS.IsLengthUnit", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
