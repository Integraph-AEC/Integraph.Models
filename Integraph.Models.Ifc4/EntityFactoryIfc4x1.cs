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
using Integraph.Models.Common.Step21;
using Integraph.Models.Ifc4.ProductExtension;
using Integraph.Models.Ifc4.GeometricConstraintResource;
using Integraph.Models.Ifc4.GeometryResource;
using Integraph.Models.Ifc4.GeometricModelResource;
using Integraph.Models.Common;

namespace Integraph.Models.Ifc4
{
	public sealed class EntityFactoryIfc4x1 : IEntityFactory
	{
		private static readonly System.Reflection.Assembly _assembly;
		private static readonly IEnumerable<IEntityFactory> _references;
		
		static EntityFactoryIfc4x1()
		{
			_assembly = typeof(EntityFactoryIfc4x1).Assembly;
			_references = new IEntityFactory[] {
				new EntityFactoryIfc4(),
				
			};
		}

		public T New<T>(IModel model, int entityLabel, bool activated) where T: IInstantiableEntity
		{
			return (T)New(model, typeof(T), entityLabel, activated);
		}

		public T New<T>(IModel model, Action<T> init, int entityLabel, bool activated) where T: IInstantiableEntity
		{
			var o = New<T>(model, entityLabel, activated);
			if (init != null)
				init(o);
			return o;
		}

		public IInstantiableEntity New(IModel model, Type t, int entityLabel, bool activated)
		{
			//check that the type is from this assembly
			if(t.Assembly != _assembly)
				throw new Exception("This factory only creates types from its assembly");

			return New(model, t.Name, entityLabel, activated);
		}

		public IInstantiableEntity New(IModel model, string typeName, int entityLabel, bool activated)
		{
			if (model == null || string.IsNullOrWhiteSpace(typeName) || entityLabel < 0)
				throw new ArgumentNullException();

			foreach (var r in _references) 
			{
				var result = r.New(model, typeName, entityLabel, activated);
				if (result != null)
					return result;
			}
			var name = typeName.ToUpperInvariant();
			switch(name)
			{
				case "IFCALIGNMENT": return new IfcAlignment ( model, entityLabel, activated );
				case "IFCALIGNMENT2DHORIZONTAL": return new IfcAlignment2DHorizontal ( model, entityLabel, activated );
				case "IFCALIGNMENT2DHORIZONTALSEGMENT": return new IfcAlignment2DHorizontalSegment ( model, entityLabel, activated );
				case "IFCALIGNMENT2DVERSEGCIRCULARARC": return new IfcAlignment2DVerSegCircularArc ( model, entityLabel, activated );
				case "IFCALIGNMENT2DVERSEGLINE": return new IfcAlignment2DVerSegLine ( model, entityLabel, activated );
				case "IFCALIGNMENT2DVERSEGPARABOLICARC": return new IfcAlignment2DVerSegParabolicArc ( model, entityLabel, activated );
				case "IFCALIGNMENT2DVERTICAL": return new IfcAlignment2DVertical ( model, entityLabel, activated );
				case "IFCALIGNMENTCURVE": return new IfcAlignmentCurve ( model, entityLabel, activated );
				case "IFCCIRCULARARCSEGMENT2D": return new IfcCircularArcSegment2D ( model, entityLabel, activated );
				case "IFCDISTANCEEXPRESSION": return new IfcDistanceExpression ( model, entityLabel, activated );
				case "IFCLINESEGMENT2D": return new IfcLineSegment2D ( model, entityLabel, activated );
				case "IFCLINEARPLACEMENT": return new IfcLinearPlacement ( model, entityLabel, activated );
				case "IFCOFFSETCURVEBYDISTANCES": return new IfcOffsetCurveByDistances ( model, entityLabel, activated );
				case "IFCORIENTATIONEXPRESSION": return new IfcOrientationExpression ( model, entityLabel, activated );
				case "IFCREFERENT": return new IfcReferent ( model, entityLabel, activated );
				case "IFCSECTIONEDSOLIDHORIZONTAL": return new IfcSectionedSolidHorizontal ( model, entityLabel, activated );
				case "IFCTRANSITIONCURVESEGMENT2D": return new IfcTransitionCurveSegment2D ( model, entityLabel, activated );
				case "IFCTRIANGULATEDIRREGULARNETWORK": return new IfcTriangulatedIrregularNetwork ( model, entityLabel, activated );
				default:
					return null;
			}
		}
		public IInstantiableEntity New(IModel model, int typeId, int entityLabel, bool activated)
		{
			if (model == null)
				throw new ArgumentNullException();

			foreach (var r in _references) 
			{
				var result = r.New(model, typeId, entityLabel, activated);
				if (result != null)
					return result;
			}

			switch(typeId)
			{
				case 1330: return new IfcAlignment ( model, entityLabel, activated );
				case 1332: return new IfcAlignment2DHorizontal ( model, entityLabel, activated );
				case 1333: return new IfcAlignment2DHorizontalSegment ( model, entityLabel, activated );
				case 1335: return new IfcAlignment2DVerSegCircularArc ( model, entityLabel, activated );
				case 1336: return new IfcAlignment2DVerSegLine ( model, entityLabel, activated );
				case 1337: return new IfcAlignment2DVerSegParabolicArc ( model, entityLabel, activated );
				case 1338: return new IfcAlignment2DVertical ( model, entityLabel, activated );
				case 1347: return new IfcAlignmentCurve ( model, entityLabel, activated );
				case 1340: return new IfcCircularArcSegment2D ( model, entityLabel, activated );
				case 1348: return new IfcDistanceExpression ( model, entityLabel, activated );
				case 1343: return new IfcLineSegment2D ( model, entityLabel, activated );
				case 1349: return new IfcLinearPlacement ( model, entityLabel, activated );
				case 1351: return new IfcOffsetCurveByDistances ( model, entityLabel, activated );
				case 1352: return new IfcOrientationExpression ( model, entityLabel, activated );
				case 1353: return new IfcReferent ( model, entityLabel, activated );
				case 1355: return new IfcSectionedSolidHorizontal ( model, entityLabel, activated );
				case 1356: return new IfcTransitionCurveSegment2D ( model, entityLabel, activated );
				case 1357: return new IfcTriangulatedIrregularNetwork ( model, entityLabel, activated );
				default:
					return null;
			}
		}

		public IExpressValueType New(string typeName)
		{
			if (typeName == null)
				throw new ArgumentNullException();

			foreach (var r in _references) 
			{
				var result = r.New(typeName);
				if (result != null)
					return result;
			}
			var name = typeName.ToUpperInvariant();
			switch(name)
			{
				default:
					return null;
			}
		}

		private static readonly List<string> _schemasIds = new List<string> { "IFC4X1" };
		public IEnumerable<string> SchemasIds { get { return _schemasIds; } }

		/// <summary>
        /// Gets the Ifc Schema version of the model if this is IFC schema
        /// </summary>
		public XbimSchemaVersion SchemaVersion { 
			get
			{
				return XbimSchemaVersion.Ifc4x1;
			}
		}

	}
}
