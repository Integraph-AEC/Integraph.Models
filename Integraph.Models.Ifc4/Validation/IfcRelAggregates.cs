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
	public partial class IfcRelAggregates : IExpressValidatable
	{
		public enum IfcRelAggregatesClause
		{
			NoSelfReference,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRelAggregatesClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRelAggregatesClause.NoSelfReference:
						retVal = Functions.SIZEOF(RelatedObjects.Where(Temp => Object.ReferenceEquals(RelatingObject, Temp))) == 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.Kernel.IfcRelAggregates>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRelAggregates.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcRelAggregatesClause.NoSelfReference))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelAggregates.NoSelfReference", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
