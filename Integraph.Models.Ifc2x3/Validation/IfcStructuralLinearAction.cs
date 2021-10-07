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
namespace Integraph.Models.Ifc2x3.StructuralAnalysisDomain
{
	public partial class IfcStructuralLinearAction : IExpressValidatable
	{
		public enum IfcStructuralLinearActionClause
		{
			WR61,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcStructuralLinearActionClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcStructuralLinearActionClause.WR61:
						retVal = Functions.SIZEOF(Functions.NewArray("IFC2X3.IFCSTRUCTURALLOADLINEARFORCE", "IFC2X3.IFCSTRUCTURALLOADTEMPERATURE") * Functions.TYPEOF(this/* as IfcStructuralActivity*/.AppliedLoad)) == 1;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.StructuralAnalysisDomain.IfcStructuralLinearAction>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcStructuralLinearAction.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcStructuralLinearActionClause.WR61))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralLinearAction.WR61", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
