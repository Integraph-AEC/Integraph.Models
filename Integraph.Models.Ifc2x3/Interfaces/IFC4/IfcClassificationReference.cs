// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;

// ReSharper disable once CheckNamespace
namespace Integraph.Models.Ifc2x3.ExternalReferenceResource
{
	public partial class @IfcClassificationReference : IIfcClassificationReference
	{

		private  IIfcClassificationReferenceSelect _referencedSource4;


		[CrossSchemaAttribute(typeof(IIfcClassificationReference), 4)]
		IIfcClassificationReferenceSelect IIfcClassificationReference.ReferencedSource 
		{ 
			get
			{
				return  _referencedSource4 ?? ReferencedSource;
			} 
			set
			{
				if (value == null)
				{
					ReferencedSource = null;
					if (_referencedSource4 != null)
						SetValue(v => _referencedSource4 = v, _referencedSource4, null, "ReferencedSource", -4);
					return;
				}
				
				var val = value as IfcClassification;
				if (val != null)
				{
					ReferencedSource = val;
					if (_referencedSource4 != null)
						SetValue(v => _referencedSource4 = v, _referencedSource4, null, "ReferencedSource", -4);
					return;
				} 

				if(ReferencedSource != null)
					ReferencedSource = null;
				SetValue(v => _referencedSource4 = v, _referencedSource4, value, "ReferencedSource", -4);
				
			}
		}

		private  Ifc4.MeasureResource.IfcText? _description;


		[CrossSchemaAttribute(typeof(IIfcClassificationReference), 5)]
		Ifc4.MeasureResource.IfcText? IIfcClassificationReference.Description 
		{ 
			get
			{
				return _description;
			} 
			set
			{
				SetValue(v => _description = v, _description, value, "Description", -5);
				
			}
		}

		private  Ifc4.MeasureResource.IfcIdentifier? _sort;


		[CrossSchemaAttribute(typeof(IIfcClassificationReference), 6)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcClassificationReference.Sort 
		{ 
			get
			{
				return _sort;
			} 
			set
			{
				SetValue(v => _sort = v, _sort, value, "Sort", -6);
				
			}
		}
		IEnumerable<IIfcRelAssociatesClassification> IIfcClassificationReference.ClassificationRefForObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesClassification>(e => (e.RelatingClassification as IfcClassificationReference) == this, "RelatingClassification", this);
			} 
		}
		IEnumerable<IIfcClassificationReference> IIfcClassificationReference.HasReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcClassificationReference>(e => (e.ReferencedSource as IfcClassificationReference) == this, "ReferencedSource", this);
			} 
		}
	//## Custom code
	//##
	}
}