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
namespace Integraph.Models.Ifc4.HvacDomain
{
	public partial class IfcUnitaryEquipmentType : IExpressValidatable
	{
		public enum IfcUnitaryEquipmentTypeClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcUnitaryEquipmentTypeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcUnitaryEquipmentTypeClause.CorrectPredefinedType:
						retVal = (PredefinedType != IfcUnitaryEquipmentTypeEnum.USERDEFINED) || ((PredefinedType == IfcUnitaryEquipmentTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElementType*/.ElementType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.HvacDomain.IfcUnitaryEquipmentType>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcUnitaryEquipmentType.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcUnitaryEquipmentTypeClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcUnitaryEquipmentType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
