// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;

namespace Integraph.Models.Ifc2x3.MeasureResource
{
	[ExpressType("IfcEnergyMeasure", 331)]
	[DefinedType(typeof(double))]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcEnergyMeasure : IfcDerivedMeasureValue, IExpressValueType, IExpressRealType, System.IEquatable<double>
	{ 
		private double _value;
        
		public object Value
        {
            get { return _value; }
        }

 
		double IExpressRealType.Value { get { return _value; } }

		public override string ToString()
        {
            return _value.ToString("R", Culture);
        }
        public IfcEnergyMeasure(double val)
        {
            _value = val;
        }

	    private static readonly System.Globalization.CultureInfo Culture = new System.Globalization.CultureInfo("en-US");

		public IfcEnergyMeasure(string val)
        {
			_value = System.Convert.ToDouble(val, Culture);
        }

        public static implicit operator IfcEnergyMeasure(double value)
        {
            return new IfcEnergyMeasure(value);
        }

        public static implicit operator double(IfcEnergyMeasure obj)
        {
            return obj._value;

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return ((IfcEnergyMeasure) obj)._value == _value;
        }

		public bool Equals(double other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcEnergyMeasure obj1, IfcEnergyMeasure obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcEnergyMeasure obj1, IfcEnergyMeasure obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
            _value = value.RealVal;
            
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(double);
			}
		}
		#endregion


	}
}