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
namespace Integraph.Models.Ifc4.QuantityResource
{
	public partial class IfcPhysicalComplexQuantity : IExpressValidatable
	{
		public enum IfcPhysicalComplexQuantityClause
		{
			NoSelfReference,
			UniqueQuantityNames,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPhysicalComplexQuantityClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPhysicalComplexQuantityClause.NoSelfReference:
						retVal = Functions.SIZEOF(HasQuantities.Where(temp => Object.ReferenceEquals(this, temp))) == 0;
						break;
					case IfcPhysicalComplexQuantityClause.UniqueQuantityNames:
						retVal = Functions.IfcUniqueQuantityNames(HasQuantities);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.QuantityResource.IfcPhysicalComplexQuantity>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPhysicalComplexQuantity.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPhysicalComplexQuantityClause.NoSelfReference))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPhysicalComplexQuantity.NoSelfReference", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcPhysicalComplexQuantityClause.UniqueQuantityNames))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPhysicalComplexQuantity.UniqueQuantityNames", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
