using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Reflection;

namespace EVApiMOTC.Extensions
{
    public static class EnumExtensions
    {
        private static readonly ConcurrentDictionary<Enum, string> EnumDescriptions = new ConcurrentDictionary<Enum, string>();

        /// <summary>
        /// Retrieves the description attribute of an enumeration value.
        /// </summary>
        /// <param name="value">The enumeration value for which to retrieve the description.</param>
        /// <returns>If the enumeration value has a description attribute, it returns the description; otherwise, it returns the string representation of the enumeration value.</returns>
        public static string GetDescription(this Enum value)
        {
            if (!EnumDescriptions.TryGetValue(value, out var description))
            {
                FieldInfo fi = value.GetType().GetField(value.ToString());
                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                description = attributes != null && attributes.Length > 0
                    ? attributes[0].Description
                    : value.ToString();

                EnumDescriptions.TryAdd(value, description);
            }

            return description;
        }
    }
}
