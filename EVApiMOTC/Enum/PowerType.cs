using System.ComponentModel;

namespace EVApiMOTC.EnumType
{
    public enum PowerType
    {
        [Description("交流電")]
        AC = 1,

        [Description("直流電")]
        DC = 2,
    }
}
