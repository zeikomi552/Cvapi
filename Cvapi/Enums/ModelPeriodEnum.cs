using System.ComponentModel;

namespace Cvapi.Models.Civitai.Enums
{
    public enum ModelPeriodEnum
    {
        [Description("")]
        Empty,
        [Description("AllTime")]
        AllTime,
        [Description("Year")]
        Year,
        [Description("Month")]
        Month,
        [Description("Week")]
        Week,
        [Description("Day")]
        Day
    }
}
