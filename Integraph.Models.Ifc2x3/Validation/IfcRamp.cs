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
	public partial class IfcRamp : IExpressValidatable
	{
		public enum IfcRampClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRampClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRampClause.WR1:
						retVal = (Functions.HIINDEX(this/* as IfcObjectDefinition*/.IsDecomposedBy) == 0) || ((Functions.HIINDEX(this/* as IfcObjectDefinition*/.IsDecomposedBy) == 1) && (!(Functions.EXISTS(this/* as IfcProduct*/.Representation))));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.SharedBldgElements.IfcRamp>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRamp.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcRampClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRamp.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
