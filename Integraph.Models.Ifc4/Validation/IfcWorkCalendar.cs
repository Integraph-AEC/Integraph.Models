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
namespace Integraph.Models.Ifc4.ProcessExtension
{
	public partial class IfcWorkCalendar : IExpressValidatable
	{
		public enum IfcWorkCalendarClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcWorkCalendarClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcWorkCalendarClause.CorrectPredefinedType:
						retVal = !(Functions.EXISTS(PredefinedType)) || (PredefinedType != IfcWorkCalendarTypeEnum.USERDEFINED) || ((PredefinedType == IfcWorkCalendarTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcObject*/.ObjectType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProcessExtension.IfcWorkCalendar>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcWorkCalendar.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcWorkCalendarClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcWorkCalendar.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
