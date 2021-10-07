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
namespace Integraph.Models.Ifc4.ExternalReferenceResource
{
	public partial class IfcExternalReference : IExpressValidatable
	{
		public enum IfcExternalReferenceClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcExternalReferenceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcExternalReferenceClause.WR1:
						retVal = Functions.EXISTS(Identification) || Functions.EXISTS(Location) || Functions.EXISTS(Name);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ExternalReferenceResource.IfcExternalReference>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcExternalReference.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcExternalReferenceClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcExternalReference.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
