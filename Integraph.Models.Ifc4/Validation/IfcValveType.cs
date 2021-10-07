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
	public partial class IfcValveType : IExpressValidatable
	{
		public enum IfcValveTypeClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcValveTypeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcValveTypeClause.CorrectPredefinedType:
						retVal = (PredefinedType != IfcValveTypeEnum.USERDEFINED) || ((PredefinedType == IfcValveTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElementType*/.ElementType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.HvacDomain.IfcValveType>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcValveType.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcValveTypeClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcValveType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
