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
namespace Integraph.Models.Ifc4.SharedFacilitiesElements
{
	public partial class IfcSystemFurnitureElementType : IExpressValidatable
	{
		public enum IfcSystemFurnitureElementTypeClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcSystemFurnitureElementTypeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcSystemFurnitureElementTypeClause.CorrectPredefinedType:
						retVal = (PredefinedType != IfcSystemFurnitureElementTypeEnum.USERDEFINED) || ((PredefinedType == IfcSystemFurnitureElementTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElementType*/.ElementType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.SharedFacilitiesElements.IfcSystemFurnitureElementType>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcSystemFurnitureElementType.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcSystemFurnitureElementTypeClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSystemFurnitureElementType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
