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
namespace Integraph.Models.Ifc2x3.GeometricModelResource
{
	public partial class IfcGeometricCurveSet : IExpressValidatable
	{
		public enum IfcGeometricCurveSetClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcGeometricCurveSetClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcGeometricCurveSetClause.WR1:
						retVal = Functions.SIZEOF(this/* as IfcGeometricSet*/.Elements.Where(Temp => Functions.TYPEOF(Temp).Contains("IFC2X3.IFCSURFACE"))) == 0;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometricModelResource.IfcGeometricCurveSet>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcGeometricCurveSet.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcGeometricCurveSetClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcGeometricCurveSet.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
