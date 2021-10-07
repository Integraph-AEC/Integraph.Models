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
namespace Integraph.Models.Ifc2x3.PresentationDefinitionResource
{
	public partial class IfcTextureMap : IExpressValidatable
	{
		public enum IfcTextureMapClause
		{
			WR11,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcTextureMapClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcTextureMapClause.WR11:
						retVal = Functions.SIZEOF(Functions.NewArray("IFC2X3.IFCSHELLBASEDSURFACEMODEL", "IFC2X3.IFCFACEBASEDSURFACEMODEL", "IFC2X3.IFCFACETEDBREP", "IFC2X3.IFCFACETEDBREPWITHVOIDS") * Functions.TYPEOF(this/* as IfcTextureCoordinate*/.AnnotatedSurface.ItemAt(0).Item)) >= 1;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.PresentationDefinitionResource.IfcTextureMap>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcTextureMap.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcTextureMapClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTextureMap.WR11", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
