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
	public partial class IfcTendon : IExpressValidatable
	{
		public enum IfcTendonClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcTendonClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcTendonClause.WR1:
						retVal = (PredefinedType != IfcTendonTypeEnum.USERDEFINED) || ((PredefinedType == IfcTendonTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcObject*/.ObjectType));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.StructuralElementsDomain.IfcTendon>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcTendon.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcTendonClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTendon.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
