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
	public partial class IfcBuildingElement : IExpressValidatable
	{
		public enum IfcBuildingElementClause
		{
			MaxOneMaterialAssociation,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcBuildingElementClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcBuildingElementClause.MaxOneMaterialAssociation:
						retVal = Functions.SIZEOF(this/* as IfcObjectDefinition*/.HasAssociations.Where(temp => Functions.TYPEOF(temp).Contains("IFC4.IFCRELASSOCIATESMATERIAL"))) <= 1;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProductExtension.IfcBuildingElement>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcBuildingElement.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcBuildingElementClause.MaxOneMaterialAssociation))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBuildingElement.MaxOneMaterialAssociation", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
