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
namespace Integraph.Models.Ifc4.StructuralAnalysisDomain
{
	public partial class IfcStructuralSurfaceAction : IExpressValidatable
	{
		public enum IfcStructuralSurfaceActionClause
		{
			ProjectedIsGlobal,
			HasObjectType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcStructuralSurfaceActionClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcStructuralSurfaceActionClause.ProjectedIsGlobal:
						retVal = (!Functions.EXISTS(ProjectedOrTrue)) || ((ProjectedOrTrue != IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH) || (this/* as IfcStructuralActivity*/.GlobalOrLocal == IfcGlobalOrLocalEnum.GLOBAL_COORDS));
						break;
					case IfcStructuralSurfaceActionClause.HasObjectType:
						retVal = (PredefinedType != IfcStructuralSurfaceActivityTypeEnum.USERDEFINED) || Functions.EXISTS(this/* as IfcObject*/.ObjectType);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.StructuralAnalysisDomain.IfcStructuralSurfaceAction>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcStructuralSurfaceAction.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcStructuralSurfaceActionClause.ProjectedIsGlobal))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralSurfaceAction.ProjectedIsGlobal", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcStructuralSurfaceActionClause.HasObjectType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralSurfaceAction.HasObjectType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
