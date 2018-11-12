using System.Drawing;

namespace Tabulation_System.Components.Interfaces
{
    public interface IFontOnDefault
    {
        Font FontOnDefault { get; set; }

        void SetFontOnDefault();
    }

    public interface IFontOnHover
    {
        Font FontOnHover { get; set; }

        void SetFontOnHover();
    }

    public interface IFontOnClick
    {
        Font FontOnClick { get; set; }

        void SetFontOnClick();
    }

    public interface IFontOnEnter
    {
        Font FontOnEnter { get; set; }

        void SetFontOnEnter();
    }

    public interface IFontOnLeave
    {
        Font FontOnLeave { get; set; }

        void SetFontOnLeave();
    }

    public interface IFontOnCheck
    {
        Font FontOnCheck { get; set; }
    }

    public interface IFontOnUncheck
    {
        Font FontOnUncheck { get; set; }
    }
}