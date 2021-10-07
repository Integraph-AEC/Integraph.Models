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
	public partial class IfcCompositeCurve : IExpressValidatable
	{
		public enum IfcCompositeCurveClause
		{
			WR41,
			WR42,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcCompositeCurveClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcCompositeCurveClause.WR41:
						retVal = ((!ClosedCurve.Value) && (Functions.SIZEOF(Segments.Where(Temp => Temp.Transition == IfcTransitionCode.DISCONTINUOUS)) == 1)) || ((ClosedCurve.Value) && (Functions.SIZEOF(Segments.Where(Temp => Temp.Transition == IfcTransitionCode.DISCONTINUOUS)) == 0));
						break;
					case IfcCompositeCurveClause.WR42:
						retVal = Functions.SIZEOF(Segments.Where(Temp => Temp.Dim != Segments.ItemAt(0).Dim)) == 0;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometryResource.IfcCompositeCurve>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcCompositeCurve.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcCompositeCurveClause.WR41))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompositeCurve.WR41", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCompositeCurveClause.WR42))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompositeCurve.WR42", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
