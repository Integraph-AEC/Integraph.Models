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
	public partial class IfcProduct : IExpressValidatable
	{
		public enum IfcProductClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcProductClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcProductClause.WR1:
						retVal = (Functions.EXISTS(Representation) && Functions.EXISTS(ObjectPlacement)) || (Functions.EXISTS(Representation) && (!(Functions.TYPEOF(Representation).Contains("IFC2X3.IFCPRODUCTDEFINITIONSHAPE")))) || (!(Functions.EXISTS(Representation)));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.Kernel.IfcProduct>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcProduct.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcProductClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcProduct.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
