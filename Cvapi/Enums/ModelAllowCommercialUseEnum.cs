using System.ComponentModel;

namespace Cvapi.Models.Civitai.Enums
{
    public enum ModelAllowCommercialUseEnum
    {
        [Description("")]
        Empty,
        [Description("None")]
        None,
        [Description("Image")]
        Image,
        [Description("Rent")]
        Rent,
        [Description("Sell")]
        Sell
    }
}
