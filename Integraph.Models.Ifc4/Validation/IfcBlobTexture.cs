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
	public partial class IfcBlobTexture : IExpressValidatable
	{
		public enum IfcBlobTextureClause
		{
			SupportedRasterFormat,
			RasterCodeByteStream,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcBlobTextureClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcBlobTextureClause.SupportedRasterFormat:
						retVal = Functions.NewTypesArray("BMP", "JPG", "GIF", "PNG").Contains(this.RasterFormat);
						break;
					case IfcBlobTextureClause.RasterCodeByteStream:
						retVal = Functions.BLENGTH(RasterCode) % 8 == 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.PresentationAppearanceResource.IfcBlobTexture>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcBlobTexture.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcBlobTextureClause.SupportedRasterFormat))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBlobTexture.SupportedRasterFormat", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcBlobTextureClause.RasterCodeByteStream))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBlobTexture.RasterCodeByteStream", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
