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
namespace Integraph.Models.Ifc2x3.RepresentationResource
{
	public partial class IfcGeometricRepresentationSubContext : IExpressValidatable
	{
		public enum IfcGeometricRepresentationSubContextClause
		{
			WR31,
			WR32,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcGeometricRepresentationSubContextClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcGeometricRepresentationSubContextClause.WR31:
						retVal = !(Functions.TYPEOF(ParentContext).Contains("IFC2X3.IFCGEOMETRICREPRESENTATIONSUBCONTEXT"));
						break;
					case IfcGeometricRepresentationSubContextClause.WR32:
						retVal = (TargetView != IfcGeometricProjectionEnum.USERDEFINED) || ((TargetView == IfcGeometricProjectionEnum.USERDEFINED) && Functions.EXISTS(UserDefinedTargetView));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.RepresentationResource.IfcGeometricRepresentationSubContext>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcGeometricRepresentationSubContext.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcGeometricRepresentationSubContextClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcGeometricRepresentationSubContext.WR31", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcGeometricRepresentationSubContextClause.WR32))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcGeometricRepresentationSubContext.WR32", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
