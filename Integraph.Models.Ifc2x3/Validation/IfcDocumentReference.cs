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
namespace Integraph.Models.Ifc2x3.ExternalReferenceResource
{
	public partial class IfcDocumentReference : IExpressValidatable
	{
		public enum IfcDocumentReferenceClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcDocumentReferenceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcDocumentReferenceClause.WR1:
						retVal = Functions.EXISTS(Name) ^ Functions.EXISTS(ReferenceToDocument.ItemAt(0));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ExternalReferenceResource.IfcDocumentReference>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcDocumentReference.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcDocumentReferenceClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDocumentReference.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
