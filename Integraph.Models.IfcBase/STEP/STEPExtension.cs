using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Integraph.Models.IfcBase.STEP
{
    /// <summary>
    ///     Extensions for writing objects to STEP.
    /// </summary>
    public static class StepExtensions
    {
        private const string NullToken = "$";

        public static string ToStepValue(this IEnumerable<IConvertibleToStep> list, bool isSelectOption = false)
        {
            var values = list.Select(item => item.ToStepValue(isSelectOption)).ToList();
            if (values.Count == 0) return "$";
            return "(" + string.Join(", ", values.ToArray()) + ")";
        }

        public static string ToStepValue(this IEnumerable<IEnumerable<IConvertibleToStep>> lists,
            bool isSelectOption = false)
        {
            var values = new List<string>();
            foreach (var list in lists)
            {
                var subValues = list.Select(item => item.ToStepValue(isSelectOption)).ToList();
                values.Add("(" + string.Join(", ", subValues.ToArray()) + ")");
                subValues.Clear();
            }

            return values.Count == 0 ? "$" : $"({string.Join(", ", values.ToArray())})";
        }

        public static string ToStepValue(this IEnumerable<int> list, bool isSelectOption = false)
        {
            var values = list.Select(item => item.ToStepValue(isSelectOption)).ToList();
            if (values.Count == 0) return "$";
            return "(" + string.Join(", ", values.ToArray()) + ")";
        }

        public static string ToStepValue(this IEnumerable<double> list, bool isSelectOption = false)
        {
            var values = list.Select(item => item.ToStepValue(isSelectOption)).ToList();
            if (values.Count == 0) return "$";
            return "(" + string.Join(", ", values.ToArray()) + ")";
        }

        public static string ToStepValue(this IEnumerable<byte[]> list, bool isSelectOption = false)
        {
            var values = list.Select(item => item.ToStepValue(isSelectOption)).ToList();
            return values.Count == 0 ? "$" : $"({string.Join(", ", values.ToArray())})";
        }

        public static string ToStepValue(this IEnumerable<IEnumerable<int>> lists, bool isSelectOption = false)
        {
            var values = new List<string>();
            foreach (var list in lists)
            {
                var subValues = list.Select(item => item.ToStepValue(isSelectOption)).ToList();
                values.Add($"({string.Join(", ", subValues.ToArray())})");
                subValues.Clear();
            }

            return values.Count == 0 ? "$" : $"({string.Join(", ", values.ToArray())})";
        }

        public static string ToStepValue(this IEnumerable<IEnumerable<double>> lists, bool isSelectOption = false)
        {
            var values = new List<string>();
            foreach (var list in lists)
            {
                var subValues = list.Select(item => item.ToStepValue(isSelectOption)).ToList();
                values.Add($"({string.Join(", ", subValues.ToArray())})");
                subValues.Clear();
            }

            return values.Count == 0 ? "$" : $"({string.Join(", ", values.ToArray())})";
        }

        public static string ToStepValue(this bool value, bool isSelectOption = false)
        {
            return value ? ".T." : ".F.";
        }

        public static string ToStepValue(this bool? value, bool isSelectOption = false)
        {
            return value switch
            {
                null => "$",
                true => ".T.",
                _ => ".F."
            };
        }

        public static string ToStepValue(this int value, bool isSelectOption = false)
        {
            return value.ToString();
        }

        public static string ToStepValue(this byte[] value, bool isSelectOption = false)
        {
            return value == null ? NullToken : value.ToString();
        }

        public static string ToStepValue(this double value, bool isSelectOption = false)
        {
            return value.ToString(value % 1 == 0 ? "0.0" : "F6", CultureInfo.InvariantCulture);
        }

        public static string ToStepValue(this string value, bool isSelectOption = false)
        {
            return value == null ? NullToken : "'" + value + "'";
        }

        public static string ToStepValue(this Enum value, bool isSelectOption = false)
        {
            return value == null ? NullToken : "." + value + ".";
        }
    }
}