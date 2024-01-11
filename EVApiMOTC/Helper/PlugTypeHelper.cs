using EVApiMOTC.EnumType;
using EVApiMOTC.Extensions;
using System;

namespace EVApiMOTC.Helper
{
    public static class PlugTypeHelper
    {
        /// <summary>
        /// Determines the plug type based on the provided charging connector name and sets the power type.
        /// </summary>
        /// <param name="ccdName">The charging connector name to determine the plug type from.</param>
        /// <param name="powerType">The power type (AC or DC) determined from the charging connector name.</param>
        /// <returns>An integer representing the plug type.</returns>
        public static int DeterminePlugType(string ccdName, out PowerType powerType)
        {
            var plugType = ConnectorPowerType.Unknown;
            powerType = PowerType.AC;

            if (!string.IsNullOrEmpty(ccdName))
            {
                if (IsMatch(ccdName, ConnectorPowerType.CCS1.GetDescription().ToUpper()))
                {
                    powerType = PowerType.DC;
                    plugType = ConnectorPowerType.CCS1;
                }
                else if (IsMatch(ccdName, ConnectorPowerType.CCS2.GetDescription().ToUpper()))
                {
                    powerType = PowerType.DC;
                    plugType = ConnectorPowerType.CCS2;
                }
                else if (IsMatch(ccdName, ConnectorPowerType.CHAdeMO.GetDescription().ToUpper()))
                {
                    powerType = PowerType.DC;
                    plugType = ConnectorPowerType.CHAdeMO;
                }
                else if (IsMatch(ccdName, ConnectorPowerType.TeslaTPC.GetDescription().ToUpper()))
                {
                    powerType = PowerType.AC;
                    plugType = ConnectorPowerType.TeslaTPC;
                }
                else if (IsMatch(ccdName, ConnectorPowerType.J1772.GetDescription().ToUpper()))
                {
                    powerType = PowerType.AC;
                    plugType = ConnectorPowerType.J1772;
                }
                else if (IsMatch(ccdName, ConnectorPowerType.Mennekes.GetDescription().ToUpper()))
                {
                    powerType = PowerType.AC;
                    plugType = ConnectorPowerType.Mennekes;
                }
                else
                {
                    plugType = ConnectorPowerType.Others;
                }
            }

            return (int)plugType;
        }

        private static bool IsMatch(string input, string target)
        {
            return string.Equals(input, target, StringComparison.OrdinalIgnoreCase);
        }
    }
}
