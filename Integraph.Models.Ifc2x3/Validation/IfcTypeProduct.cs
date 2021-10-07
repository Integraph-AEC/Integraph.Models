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
namespace Integraph.Models.Ifc2x3.Kernel
{
	public partial class IfcTypeProduct : IExpressValidatable
	{
		public enum IfcTypeProductClause
		{
			WR41,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcTypeProductClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcTypeProductClause.WR41:
						retVal = !(Functions.EXISTS(this/* as IfcTypeObject*/.ObjectTypeOf.ItemAt(0))) || (Functions.SIZEOF(this/* as IfcTypeObject*/.ObjectTypeOf.ItemAt(0).RelatedObjects.Where(temp => !(Functions.TYPEOF(temp).Contains("IFC2X3.IFCPRODUCT")))) == 0);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.Kernel.IfcTypeProduct>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcTypeProduct.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcTypeProductClause.WR41))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTypeProduct.WR41", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
