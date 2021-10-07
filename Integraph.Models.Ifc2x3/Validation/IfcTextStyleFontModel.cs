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
namespace Integraph.Models.Ifc2x3.PresentationResource
{
	public partial class IfcTextStyleFontModel : IExpressValidatable
	{
		public enum IfcTextStyleFontModelClause
		{
			WR31,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcTextStyleFontModelClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcTextStyleFontModelClause.WR31:
						retVal = (Functions.TYPEOF(this.FontSize).Contains("IFC2X3.IFCLENGTHMEASURE")) && (this.FontSize.AsIfcLengthMeasure() > 0);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.PresentationResource.IfcTextStyleFontModel>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcTextStyleFontModel.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcTextStyleFontModelClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTextStyleFontModel.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
