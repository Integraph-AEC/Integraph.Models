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
namespace Integraph.Models.Ifc2x3.GeometricModelResource
{
	public partial class IfcBooleanResult : IExpressValidatable
	{
		public enum IfcBooleanResultClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcBooleanResultClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcBooleanResultClause.WR1:
						retVal = FirstOperand.Dim == SecondOperand.Dim;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometricModelResource.IfcBooleanResult>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcBooleanResult.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcBooleanResultClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBooleanResult.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
