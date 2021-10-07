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
namespace Integraph.Models.Ifc4.PresentationAppearanceResource
{
	public partial struct IfcTextTransformation : IExpressValidatable
	{
		public enum IfcTextTransformationClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcTextTransformationClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcTextTransformationClause.WR1:
						retVal = Functions.NewTypesArray("capitalize", "uppercase", "lowercase", "none").Contains(this);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.PresentationAppearanceResource.IfcTextTransformation>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcTextTransformation.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcTextTransformationClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTextTransformation.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
