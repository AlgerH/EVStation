using System.ComponentModel;

namespace EVApiMOTC.EnumType
{
    public enum DayType
    {
        [Description("每日")]
        Daily = 1,

        [Description("平日")]
        Weekdays = 2,

        [Description("假日")]
        Weekends = 3,

        [Description("假日含國定例假日")]
        WeekendsHolidays = 4,

        [Description("其他類型")]
        Unknown = 255,
    }
}
