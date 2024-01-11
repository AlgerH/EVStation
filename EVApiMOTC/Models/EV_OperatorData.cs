using System.ComponentModel;

namespace EVApiMOTC.Models
{
    public class EV_OperatorData
    {
        public int UKey { get; set; }

        [Description("營運業者代碼 ")]
        public string? OperatorID { get; set; }

        [Description("營運業者名稱（中文名稱）")]
        public string? OperatorName_Zh_tw { get; set; }

        [Description("營運業者名稱（英文名稱）")]
        public string? OperatorName_En { get; set; }

        [Description("營運業者名稱（業管機關簡碼 ）")]
        public string? AuthorityCode { get; set; }

        [Description("營運業者名稱（業管機關名稱 ）")]
        public string? AuthorityName { get; set; }

        [Description("營運業者連絡電話")]
        public string? Telephone { get; set; }

        [Description("營運業者地址")]
        public string? Address { get; set; }

        [Description("營運業者官網網址")]
        public string? WebURL { get; set; }

        [Description("營運業者 Logo 網址")]
        public string? LogoURL { get; set; }

        [Description("營運業者服務條款網址")]
        public string? TsAndCsURL { get; set; }

        [Description("公司統一編號 ")]
        public string? BAN { get; set; }

        [Description("是否已刪除")]
        public bool? IsDelete { get; set; }

        [Description("建立人員")]
        public string? CreateName { get; set; }

        [Description("建立時間")]
        public DateTime? CreateTime { get; set; }

        [Description("修改人員")]
        public string? UpdateName { get; set; }

        [Description("修改時間")]
        public DateTime? UpdateTime { get; set; }	
    }
}
