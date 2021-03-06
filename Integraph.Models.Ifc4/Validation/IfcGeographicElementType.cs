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
namespace Integraph.Models.Ifc4.ProductExtension
{
	public partial class IfcGeographicElementType : IExpressValidatable
	{
		public enum IfcGeographicElementTypeClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcGeographicElementTypeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcGeographicElementTypeClause.CorrectPredefinedType:
						retVal = (PredefinedType != IfcGeographicElementTypeEnum.USERDEFINED) || ((PredefinedType == IfcGeographicElementTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElementType*/.ElementType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProductExtension.IfcGeographicElementType>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcGeographicElementType.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcGeographicElementTypeClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcGeographicElementType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
