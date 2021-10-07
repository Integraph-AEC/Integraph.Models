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
	public partial class IfcRelDecomposes : IExpressValidatable
	{
		public enum IfcRelDecomposesClause
		{
			WR31,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRelDecomposesClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRelDecomposesClause.WR31:
						retVal = Functions.SIZEOF(RelatedObjects.Where(Temp => Object.ReferenceEquals(RelatingObject, Temp))) == 0;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.Kernel.IfcRelDecomposes>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRelDecomposes.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcRelDecomposesClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRelDecomposes.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
