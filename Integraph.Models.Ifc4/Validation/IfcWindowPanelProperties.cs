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
namespace Integraph.Models.Ifc4.ArchitectureDomain
{
	public partial class IfcWindowPanelProperties : IExpressValidatable
	{
		public enum IfcWindowPanelPropertiesClause
		{
			ApplicableToType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcWindowPanelPropertiesClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcWindowPanelPropertiesClause.ApplicableToType:
						retVal = (Functions.EXISTS(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0))) && ((Functions.TYPEOF(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0)).Contains("IFC4.IFCWINDOWTYPE")) || (Functions.TYPEOF(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0)).Contains("IFC4.IFCWINDOWSTYLE")));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ArchitectureDomain.IfcWindowPanelProperties>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcWindowPanelProperties.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcWindowPanelPropertiesClause.ApplicableToType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcWindowPanelProperties.ApplicableToType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
