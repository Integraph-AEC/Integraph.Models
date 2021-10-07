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
	public partial class IfcOrientedEdge : IExpressValidatable
	{
		public enum IfcOrientedEdgeClause
		{
			EdgeElementNotOriented,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcOrientedEdgeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcOrientedEdgeClause.EdgeElementNotOriented:
						retVal = !(Functions.TYPEOF(EdgeElement).Contains("IFC4.IFCORIENTEDEDGE"));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.TopologyResource.IfcOrientedEdge>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcOrientedEdge.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcOrientedEdgeClause.EdgeElementNotOriented))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcOrientedEdge.EdgeElementNotOriented", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
