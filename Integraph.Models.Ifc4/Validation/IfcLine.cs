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
namespace Integraph.Models.Ifc4.GeometryResource
{
	public partial class IfcLine : IExpressValidatable
	{
		public enum IfcLineClause
		{
			SameDim,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcLineClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcLineClause.SameDim:
						retVal = Dir.Dim == Pnt.Dim;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometryResource.IfcLine>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcLine.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcLineClause.SameDim))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcLine.SameDim", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
