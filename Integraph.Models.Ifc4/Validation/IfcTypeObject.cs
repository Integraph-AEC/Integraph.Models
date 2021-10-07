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
	public partial class IfcTypeObject : IExpressValidatable
	{
		public enum IfcTypeObjectClause
		{
			NameRequired,
			UniquePropertySetNames,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcTypeObjectClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcTypeObjectClause.NameRequired:
						retVal = Functions.EXISTS(this/* as IfcRoot*/.Name);
						break;
					case IfcTypeObjectClause.UniquePropertySetNames:
						retVal = (!(Functions.EXISTS(HasPropertySets))) || Functions.IfcUniquePropertySetNames(HasPropertySets);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.Kernel.IfcTypeObject>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcTypeObject.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcTypeObjectClause.NameRequired))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTypeObject.NameRequired", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcTypeObjectClause.UniquePropertySetNames))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTypeObject.UniquePropertySetNames", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
