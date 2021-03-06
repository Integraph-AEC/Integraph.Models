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
namespace Integraph.Models.Ifc4.TopologyResource
{
	public partial class IfcPolyLoop : IExpressValidatable
	{
		public enum IfcPolyLoopClause
		{
			AllPointsSameDim,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPolyLoopClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPolyLoopClause.AllPointsSameDim:
						retVal = Functions.SIZEOF(Polygon.Where(Temp => Temp.Dim != Polygon.ItemAt(0).Dim)) == 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.TopologyResource.IfcPolyLoop>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPolyLoop.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPolyLoopClause.AllPointsSameDim))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPolyLoop.AllPointsSameDim", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
