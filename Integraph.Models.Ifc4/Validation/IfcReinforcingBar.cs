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
namespace Integraph.Models.Ifc4.StructuralElementsDomain
{
	public partial class IfcReinforcingBar : IExpressValidatable
	{
		public enum IfcReinforcingBarClause
		{
			CorrectPredefinedType,
			CorrectTypeAssigned,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcReinforcingBarClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcReinforcingBarClause.CorrectPredefinedType:
						retVal = !Functions.EXISTS(PredefinedType) || (PredefinedType != IfcReinforcingBarTypeEnum.USERDEFINED) || ((PredefinedType == IfcReinforcingBarTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcObject*/.ObjectType));
						break;
					case IfcReinforcingBarClause.CorrectTypeAssigned:
						retVal = (Functions.SIZEOF(IsTypedBy) == 0) || (Functions.TYPEOF(this/* as IfcObject*/.IsTypedBy.ItemAt(0).RelatingType).Contains("IFC4.IFCREINFORCINGBARTYPE"));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.StructuralElementsDomain.IfcReinforcingBar>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcReinforcingBar.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcReinforcingBarClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcReinforcingBar.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcReinforcingBarClause.CorrectTypeAssigned))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcReinforcingBar.CorrectTypeAssigned", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
