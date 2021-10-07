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
namespace Integraph.Models.Ifc2x3.ElectricalDomain
{
	public partial class IfcElectricDistributionPoint : IExpressValidatable
	{
		public enum IfcElectricDistributionPointClause
		{
			WR31,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcElectricDistributionPointClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcElectricDistributionPointClause.WR31:
						retVal = (DistributionPointFunction != IfcElectricDistributionPointFunctionEnum.USERDEFINED) || ((DistributionPointFunction == IfcElectricDistributionPointFunctionEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElectricDistributionPoint*/.UserDefinedFunction));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ElectricalDomain.IfcElectricDistributionPoint>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcElectricDistributionPoint.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcElectricDistributionPointClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcElectricDistributionPoint.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
