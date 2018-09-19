

using System.ComponentModel;

namespace MiniWeb.Persistence.Model
{
    public enum Continent
    {
        Unknown = 0,
        [Description("Europe")]
        Europe = 1,
        [Description("Asia")]
        Asia = 2,
        [Description("North America")]
        NorthAmerica = 3,
        [Description("South America")]
        SouthAmerica = 4,
        [Description("Africa")]
        Africa = 5,
        [Description("Oceania")]
        Oceania = 6,
        [Description("Antarctica")]
        Antarctica = 7
    }
}