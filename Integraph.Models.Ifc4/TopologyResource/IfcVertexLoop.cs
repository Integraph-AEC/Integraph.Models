// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.TopologyResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcVertexLoop
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcVertexLoop : IIfcLoop
	{
		IIfcVertex @LoopVertex { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.TopologyResource
{
	[ExpressType("IfcVertexLoop", 244)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVertexLoop : IfcLoop, IInstantiableEntity, IIfcVertexLoop, IContainsEntityReferences, IEquatable<@IfcVertexLoop>
	{
		#region IIfcVertexLoop explicit implementation
		IIfcVertex IIfcVertexLoop.LoopVertex { 
 
 
			get { return @LoopVertex; } 
			set { LoopVertex = value as IfcVertex;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVertexLoop(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcVertex _loopVertex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcVertex @LoopVertex 
		{ 
			get 
			{
				if(_activated) return _loopVertex;
				Activate();
				return _loopVertex;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _loopVertex = v, _loopVertex, value,  "LoopVertex", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_loopVertex = (IfcVertex)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcVertexLoop other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@LoopVertex != null)
					yield return @LoopVertex;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}