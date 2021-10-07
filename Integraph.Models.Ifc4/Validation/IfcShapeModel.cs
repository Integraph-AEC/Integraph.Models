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
namespace Integraph.Models.Ifc4.RepresentationResource
{
	public partial class IfcShapeModel : IExpressValidatable
	{
		public enum IfcShapeModelClause
		{
			WR11,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcShapeModelClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcShapeModelClause.WR11:
						retVal = (Functions.SIZEOF(this/* as IfcRepresentation*/.OfProductRepresentation) == 1) ^ (Functions.SIZEOF(this/* as IfcRepresentation*/.RepresentationMap) == 1) ^ (Functions.SIZEOF(OfShapeAspect) == 1);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.RepresentationResource.IfcShapeModel>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcShapeModel.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcShapeModelClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcShapeModel.WR11", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
