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
	public partial class IfcObject : IExpressValidatable
	{
		public enum IfcObjectClause
		{
			UniquePropertySetNames,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcObjectClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcObjectClause.UniquePropertySetNames:
						retVal = ((Functions.SIZEOF(IsDefinedBy) == 0) || Functions.IfcUniqueDefinitionNames(IsDefinedBy));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.Kernel.IfcObject>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcObject.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcObjectClause.UniquePropertySetNames))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcObject.UniquePropertySetNames", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
