using System.Drawing;
using Tabulation_System.Commons.Enums;

namespace Tabulation_System.Components.Interfaces
{
    public interface IGradient : IGradientOnDefault, IGradientOnHover, IGradientOnClick
    {
    }

    public interface IGradientOnDefault
    {
        ColorCombination ColorToneOnDefault { get; set; }

        Color ColorAOnDefault { get; set; }
        Color ColorBOnDefault { get; set; }
        Color ColorCOnDefault { get; set; }

        int GradientAngleOnDefault { get; set; }

        void SetGradientPaintOnDefault();
    }

    public interface IGradientOnHover
    {
        ColorCombination ColorToneOnHover { get; set; }

        Color ColorAOnHover { get; set; }
        Color ColorBOnHover { get; set; }
        Color ColorCOnHover { get; set; }

        int GradientAngleOnHover { get; set; }

        void SetGradientPaintOnHover();
    }

    public interface IGradientOnClick
    {
        ColorCombination ColorToneOnClick { get; set; }

        Color ColorAOnClick { get; set; }
        Color ColorBOnClick { get; set; }
        Color ColorCOnClick { get; set; }

        int GradientAngleOnClick { get; set; }

        void SetGradientPaintOnClick();
    }
}