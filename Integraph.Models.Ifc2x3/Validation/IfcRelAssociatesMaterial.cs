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
namespace Integraph.Models.Ifc2x3.ProductExtension
{
	public partial class IfcRelAssociatesMaterial : IExpressValidatable
	{
		public enum IfcRelAssociatesMaterialClause
		{
			WR21,
			WR22,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRelAssociatesMaterialClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRelAssociatesMaterialClause.WR21:
						retVal = Functions.SIZEOF(this/* as IfcRelAssociates*/.RelatedObjects.Where(temp => (Functions.TYPEOF(temp).Contains("IFC2X3.IFCFEATUREELEMENTSUBTRACTION")) || (Functions.TYPEOF(temp).Contains("IFC2X3.IFCVIRTUALELEMENT")))) == 0;
						break;
					case IfcRelAssociatesMaterialClause.WR22:
						retVal = Functions.SIZEOF(this/* as IfcRelAssociates*/.RelatedObjects.Where(temp => (!(Functions.TYPEOF(temp).Contains("IFC2X3.IFCPRODUCT")) && !(Functions.TYPEOF(temp).Contains("IFC2X3.IFCTYPEPRODUCT"))))) == 0;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ProductExtension.IfcRelAssociatesMaterial>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRelAssociatesMaterial.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcRelAssociatesMaterialClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelAssociatesMaterial.WR21", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcRelAssociatesMaterialClause.WR22))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelAssociatesMaterial.WR22", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
