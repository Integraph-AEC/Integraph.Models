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
	public partial class IfcOffsetCurve2D : IExpressValidatable
	{
		public enum IfcOffsetCurve2DClause
		{
			DimIs2D,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcOffsetCurve2DClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcOffsetCurve2DClause.DimIs2D:
						retVal = BasisCurve.Dim == 2;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometryResource.IfcOffsetCurve2D>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcOffsetCurve2D.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcOffsetCurve2DClause.DimIs2D))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcOffsetCurve2D.DimIs2D", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
