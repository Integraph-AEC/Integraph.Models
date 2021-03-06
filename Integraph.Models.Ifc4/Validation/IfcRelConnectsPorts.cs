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
	public partial class IfcRelConnectsPorts : IExpressValidatable
	{
		public enum IfcRelConnectsPortsClause
		{
			NoSelfReference,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRelConnectsPortsClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRelConnectsPortsClause.NoSelfReference:
						retVal = !Object.ReferenceEquals(RelatingPort, RelatedPort);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProductExtension.IfcRelConnectsPorts>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRelConnectsPorts.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcRelConnectsPortsClause.NoSelfReference))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelConnectsPorts.NoSelfReference", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
