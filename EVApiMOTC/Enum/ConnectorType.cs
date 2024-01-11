using System.ComponentModel;

namespace EVApiMOTC.EnumType
{
    public enum ConnectorPowerType
    {
        [Description("CCS1")]
        CCS1 = 1,

        [Description("CCS2")]
        CCS2 = 2,

        [Description("CHAdeMO")]
        CHAdeMO = 3,

        [Description("TeslaTPC")]
        TeslaTPC = 4,

        [Description("J1772(Type1)")]
        J1772 = 5,

        [Description("Mennekes(Type2)")]
        Mennekes = 6,

        [Description("Others")]
        Others = 254,

        [Description("Unknown")]
        Unknown = 255,
    }
}
