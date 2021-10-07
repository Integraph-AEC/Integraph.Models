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
namespace Integraph.Models.Ifc2x3.SharedBldgElements
{
	public partial class IfcDoorPanelProperties : IExpressValidatable
	{
		public enum IfcDoorPanelPropertiesClause
		{
			WR31,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcDoorPanelPropertiesClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcDoorPanelPropertiesClause.WR31:
						retVal = Functions.EXISTS(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0)) && (Functions.TYPEOF(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0)).Contains("IFC2X3.IFCDOORSTYLE"));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.SharedBldgElements.IfcDoorPanelProperties>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcDoorPanelProperties.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcDoorPanelPropertiesClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDoorPanelProperties.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
