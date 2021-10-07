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
namespace Integraph.Models.Ifc4.SharedComponentElements
{
	public partial class IfcBuildingElementPartType : IExpressValidatable
	{
		public enum IfcBuildingElementPartTypeClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcBuildingElementPartTypeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcBuildingElementPartTypeClause.CorrectPredefinedType:
						retVal = (PredefinedType != IfcBuildingElementPartTypeEnum.USERDEFINED) || ((PredefinedType == IfcBuildingElementPartTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElementType*/.ElementType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.SharedComponentElements.IfcBuildingElementPartType>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcBuildingElementPartType.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcBuildingElementPartTypeClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBuildingElementPartType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
