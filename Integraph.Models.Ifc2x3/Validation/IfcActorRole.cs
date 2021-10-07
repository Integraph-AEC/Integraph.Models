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
namespace Integraph.Models.Ifc2x3.ActorResource
{
	public partial class IfcActorRole : IExpressValidatable
	{
		public enum IfcActorRoleClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcActorRoleClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcActorRoleClause.WR1:
						retVal = (Role != IfcRoleEnum.USERDEFINED) || ((Role == IfcRoleEnum.USERDEFINED) && Functions.EXISTS(this.UserDefinedRole));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ActorResource.IfcActorRole>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcActorRole.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcActorRoleClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcActorRole.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
