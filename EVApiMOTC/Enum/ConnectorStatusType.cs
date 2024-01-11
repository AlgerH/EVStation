using System.ComponentModel;

namespace EVApiMOTC.EnumType
{
    public enum ConnectorStatusType
    {
        [Description("可使用(Available)[閒置]")]
        Available = 1,
        
        [Description("不可使用(UnAvailable)[佔用/充電中]")]
        Occupied = 2,
        
        [Description("不可使用(UnAvailable)[異常故障")]
        Maintenance = 3,
    }
}
