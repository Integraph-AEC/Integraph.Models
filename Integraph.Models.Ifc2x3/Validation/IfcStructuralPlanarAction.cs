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
	public partial class IfcStructuralPlanarAction : IExpressValidatable
	{
		public enum IfcStructuralPlanarActionClause
		{
			WR61,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcStructuralPlanarActionClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcStructuralPlanarActionClause.WR61:
						retVal = Functions.SIZEOF(Functions.NewArray("IFC2X3.IFCSTRUCTURALLOADPLANARFORCE", "IFC2X3.IFCSTRUCTURALLOADTEMPERATURE") * Functions.TYPEOF(this/* as IfcStructuralActivity*/.AppliedLoad)) == 1;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.StructuralAnalysisDomain.IfcStructuralPlanarAction>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcStructuralPlanarAction.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcStructuralPlanarActionClause.WR61))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralPlanarAction.WR61", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
