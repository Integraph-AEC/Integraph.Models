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
namespace Integraph.Models.Ifc4.ProductExtension
{
	public partial class IfcSpatialStructureElement : IExpressValidatable
	{
		public enum IfcSpatialStructureElementClause
		{
			WR41,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcSpatialStructureElementClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcSpatialStructureElementClause.WR41:
						retVal = (Functions.HIINDEX(this/* as IfcObjectDefinition*/.Decomposes) == 1) && (Functions.TYPEOF(this/* as IfcObjectDefinition*/.Decomposes.ItemAt(0)).Contains("IFC4.IFCRELAGGREGATES")) && ((Functions.TYPEOF(this/* as IfcObjectDefinition*/.Decomposes.ItemAt(0).RelatingObject).Contains("IFC4.IFCPROJECT")) || (Functions.TYPEOF(this/* as IfcObjectDefinition*/.Decomposes.ItemAt(0).RelatingObject).Contains("IFC4.IFCSPATIALSTRUCTUREELEMENT")));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProductExtension.IfcSpatialStructureElement>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcSpatialStructureElement.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcSpatialStructureElementClause.WR41))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSpatialStructureElement.WR41", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
