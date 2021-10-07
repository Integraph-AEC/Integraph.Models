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
namespace Integraph.Models.Ifc2x3.PresentationAppearanceResource
{
	public partial class IfcCurveStyle : IExpressValidatable
	{
		public enum IfcCurveStyleClause
		{
			WR11,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcCurveStyleClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcCurveStyleClause.WR11:
						retVal = (!(Functions.EXISTS(CurveWidth))) || (Functions.TYPEOF(CurveWidth).Contains("IFC2X3.IFCPOSITIVELENGTHMEASURE")) || ((Functions.TYPEOF(CurveWidth).Contains("IFC2X3.IFCDESCRIPTIVEMEASURE")) && (CurveWidth.AsIfcDescriptiveMeasure() == "by layer"));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.PresentationAppearanceResource.IfcCurveStyle>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcCurveStyle.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcCurveStyleClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCurveStyle.WR11", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
