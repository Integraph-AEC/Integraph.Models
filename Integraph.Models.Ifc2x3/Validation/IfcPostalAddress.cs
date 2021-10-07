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
	public partial class IfcPostalAddress : IExpressValidatable
	{
		public enum IfcPostalAddressClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPostalAddressClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPostalAddressClause.WR1:
						retVal = Functions.EXISTS(InternalLocation) || Functions.EXISTS(AddressLines) || Functions.EXISTS(PostalBox) || Functions.EXISTS(PostalCode) || Functions.EXISTS(Town) || Functions.EXISTS(Region) || Functions.EXISTS(Country);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ActorResource.IfcPostalAddress>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPostalAddress.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcPostalAddressClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPostalAddress.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
