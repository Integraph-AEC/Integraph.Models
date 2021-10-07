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
namespace Integraph.Models.Ifc4.GeometricModelResource
{
	public partial class IfcGeometricSet : IExpressValidatable
	{
		public enum IfcGeometricSetClause
		{
			ConsistentDim,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcGeometricSetClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcGeometricSetClause.ConsistentDim:
						retVal = Functions.SIZEOF(Elements.Where(Temp => Temp.Dim != Elements.ItemAt(0).Dim)) == 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometricModelResource.IfcGeometricSet>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcGeometricSet.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcGeometricSetClause.ConsistentDim))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcGeometricSet.ConsistentDim", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
