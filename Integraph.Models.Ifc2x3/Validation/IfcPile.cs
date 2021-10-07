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
namespace Integraph.Models.Ifc2x3.StructuralElementsDomain
{
	public partial class IfcPile : IExpressValidatable
	{
		public enum IfcPileClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPileClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPileClause.WR1:
						retVal = (PredefinedType != IfcPileTypeEnum.USERDEFINED) || ((PredefinedType == IfcPileTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcObject*/.ObjectType));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.StructuralElementsDomain.IfcPile>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPile.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcPileClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPile.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
