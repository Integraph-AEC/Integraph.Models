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
namespace Integraph.Models.Ifc2x3.RepresentationResource
{
	public partial class @IfcShapeAspect : IIfcShapeAspect
	{

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 1)]
		IItemSet<IIfcShapeModel> IIfcShapeAspect.ShapeRepresentations 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcShapeModel, IIfcShapeModel>(ShapeRepresentations);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 2)]
		Ifc4.MeasureResource.IfcLabel? IIfcShapeAspect.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 3)]
		Ifc4.MeasureResource.IfcText? IIfcShapeAspect.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 4)]
		Ifc4.MeasureResource.IfcLogical IIfcShapeAspect.ProductDefinitional 
		{ 
			get
			{
				//## Handle return of ProductDefinitional for which no match was found
			    return new Ifc4.MeasureResource.IfcLogical(ProductDefinitional);
			    //##
			} 
			set
			{
				ProductDefinitional = value;
				
			}
		}

		private  IIfcProductRepresentationSelect _partOfProductDefinitionShape4;


		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 5)]
		IIfcProductRepresentationSelect IIfcShapeAspect.PartOfProductDefinitionShape 
		{ 
			get
			{
				return  _partOfProductDefinitionShape4 ?? PartOfProductDefinitionShape;
			} 
			set
			{
				if (value == null)
				{
					PartOfProductDefinitionShape = null;
					if (_partOfProductDefinitionShape4 != null)
						SetValue(v => _partOfProductDefinitionShape4 = v, _partOfProductDefinitionShape4, null, "PartOfProductDefinitionShape", -5);
					return;
				}
				
				var val = value as IfcProductDefinitionShape;
				if (val != null)
				{
					PartOfProductDefinitionShape = val;
					if (_partOfProductDefinitionShape4 != null)
						SetValue(v => _partOfProductDefinitionShape4 = v, _partOfProductDefinitionShape4, null, "PartOfProductDefinitionShape", -5);
					return;
				} 

				if(PartOfProductDefinitionShape != null)
					PartOfProductDefinitionShape = null;
				SetValue(v => _partOfProductDefinitionShape4 = v, _partOfProductDefinitionShape4, value, "PartOfProductDefinitionShape", -5);
				
			}
		}
	//## Custom code
	//##
	}
}