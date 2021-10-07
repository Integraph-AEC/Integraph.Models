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
namespace Integraph.Models.Ifc4.SharedBldgElements
{
	public partial class IfcPlateStandardCase : IExpressValidatable
	{
		public enum IfcPlateStandardCaseClause
		{
			HasMaterialLayerSetUsage,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPlateStandardCaseClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPlateStandardCaseClause.HasMaterialLayerSetUsage:
						retVal = Functions.SIZEOF(Functions.USEDIN(this, "IFC4.IFCRELASSOCIATES.RELATEDOBJECTS").Where(temp => (Functions.TYPEOF(temp).Contains("IFC4.IFCRELASSOCIATESMATERIAL")) && (Functions.TYPEOF(temp.AsIfcRelAssociatesMaterial().RelatingMaterial).Contains("IFC4.IFCMATERIALLAYERSETUSAGE")))) == 1;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.SharedBldgElements.IfcPlateStandardCase>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPlateStandardCase.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcPlateStandardCaseClause.HasMaterialLayerSetUsage))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPlateStandardCase.HasMaterialLayerSetUsage", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
