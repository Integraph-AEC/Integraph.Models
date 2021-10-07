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
namespace Integraph.Models.Ifc4.ProfileResource
{
	public partial class IfcArbitraryOpenProfileDef : IExpressValidatable
	{
		public enum IfcArbitraryOpenProfileDefClause
		{
			WR11,
			WR12,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcArbitraryOpenProfileDefClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcArbitraryOpenProfileDefClause.WR11:
						retVal = (Functions.TYPEOF(this).Contains("IFC4.IFCCENTERLINEPROFILEDEF")) || (this/* as IfcProfileDef*/.ProfileType == IfcProfileTypeEnum.CURVE);
						break;
					case IfcArbitraryOpenProfileDefClause.WR12:
						retVal = Curve.Dim == 2;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProfileResource.IfcArbitraryOpenProfileDef>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcArbitraryOpenProfileDef.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcArbitraryOpenProfileDefClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcArbitraryOpenProfileDef.WR11", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcArbitraryOpenProfileDefClause.WR12))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcArbitraryOpenProfileDef.WR12", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
