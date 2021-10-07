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
	public partial class IfcPolyline : IExpressValidatable
	{
		public enum IfcPolylineClause
		{
			SameDim,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPolylineClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPolylineClause.SameDim:
						retVal = Functions.SIZEOF(Points.Where(Temp => Temp.Dim != Points.ItemAt(0).Dim)) == 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometryResource.IfcPolyline>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPolyline.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPolylineClause.SameDim))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPolyline.SameDim", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
