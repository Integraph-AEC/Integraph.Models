using System;
using Microsoft.Extensions.Logging;
using Integraph.Models.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Integraph.Models.Common.Enumerations;
using Integraph.Models.Common.ExpressValidation;
using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.ProfileResource;
using Integraph.Models.Ifc2x3.ProfilePropertyResource;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Integraph.Models.Ifc2x3.GeometryResource
{
	public partial struct IfcDimensionCount : IExpressValidatable
	{
		public enum IfcDimensionCountClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcDimensionCountClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcDimensionCountClause.WR1:
						retVal = ((0 < this) && (this <= 3) );
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometryResource.IfcDimensionCount>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcDimensionCount.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcDimensionCountClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDimensionCount.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
