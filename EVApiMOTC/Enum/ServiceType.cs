using System.ComponentModel;

namespace EVApiMOTC.EnumType
{
    public enum ServiceType
    {
        [Description("7*24 小時營業不間斷")]
        TwentyFourSevenHours = 1,

        [Description("每日特定時段才營業")]
        DailySpecificHours = 2,

        [Description("分平假日有不同的營業時段")]
        Mixed = 3,
    }
}
