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
namespace Integraph.Models.Ifc4.MaterialResource
{
	public partial class IfcMaterialLayer : IExpressValidatable
	{
		public enum IfcMaterialLayerClause
		{
			NormalizedPriority,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcMaterialLayerClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcMaterialLayerClause.NormalizedPriority:
						retVal = !(Functions.EXISTS(Priority)) || ((0 <= Priority) && (Priority <= 100) );
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.MaterialResource.IfcMaterialLayer>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcMaterialLayer.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcMaterialLayerClause.NormalizedPriority))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcMaterialLayer.NormalizedPriority", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
