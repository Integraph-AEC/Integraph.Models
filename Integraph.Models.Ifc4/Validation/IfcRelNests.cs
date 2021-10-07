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
	public partial class IfcRelNests : IExpressValidatable
	{
		public enum IfcRelNestsClause
		{
			NoSelfReference,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRelNestsClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRelNestsClause.NoSelfReference:
						retVal = Functions.SIZEOF(RelatedObjects.Where(Temp => Object.ReferenceEquals(RelatingObject, Temp))) == 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.Kernel.IfcRelNests>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRelNests.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcRelNestsClause.NoSelfReference))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelNests.NoSelfReference", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
