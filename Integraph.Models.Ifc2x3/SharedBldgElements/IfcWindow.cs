// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.ProductExtension;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.SharedBldgElements;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWindow
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWindow : IIfcBuildingElement
	{
		IfcPositiveLengthMeasure? @OverallHeight { get;  set; }
		IfcPositiveLengthMeasure? @OverallWidth { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.SharedBldgElements
{
	[ExpressType("IfcWindow", 667)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindow : IfcBuildingElement, IInstantiableEntity, IIfcWindow, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcWindow>
	{
		#region IIfcWindow explicit implementation
		IfcPositiveLengthMeasure? IIfcWindow.OverallHeight { 
 
			get { return @OverallHeight; } 
			set { OverallHeight = value;}
		}	
		IfcPositiveLengthMeasure? IIfcWindow.OverallWidth { 
 
			get { return @OverallWidth; } 
			set { OverallWidth = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindow(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _overallHeight;
		private IfcPositiveLengthMeasure? _overallWidth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 27)]
		public IfcPositiveLengthMeasure? @OverallHeight 
		{ 
			get 
			{
				if(_activated) return _overallHeight;
				Activate();
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 28)]
		public IfcPositiveLengthMeasure? @OverallWidth 
		{ 
			get 
			{
				if(_activated) return _overallWidth;
				Activate();
				return _overallWidth;
			} 
			set
			{
				SetValue( v =>  _overallWidth = v, _overallWidth, value,  "OverallWidth", 10);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_overallHeight = value.RealVal;
					return;
				case 9: 
					_overallWidth = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWindow other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}