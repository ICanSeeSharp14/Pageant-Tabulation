using System.Drawing;

namespace Tabulation_System.Components.Interfaces
{
    public interface IColorOnDefault : IBackColorOnDefault, IForeColorOnDefault
    {
    }

    public interface IColorOnHover : IBackColorOnHover, IForeColorOnHover
    {
    }

    public interface IColorOnClick : IBackColorOnClick, IForeColorOnClick
    {
    }

    public interface IColorOnEnter : IBackColorOnEnter, IForeColorOnEnter
    {
    }

    public interface IColorOnLeave : IBackColorOnLeave, IForeColorOnLeave
    {
    }

    public interface IColorOnCheck : IBackColorOnCheck, IForeColorOnCheck
    {
    }

    public interface IColorOnUncheck : IBackColorOnUncheck, IForeColorOnUncheck
    {
    }

    public interface IBackColorOnDefault
    {
        Color BackColorOnDefault { get; set; }

        void SetBackColorOnDefault();
    }

    public interface IForeColorOnDefault
    {
        Color ForeColorOnDefault { get; set; }

        void SetForeColorOnDefault();
    }

    public interface IBackColorOnHover
    {
        Color BackColorOnHover { get; set; }

        void SetBackColorOnHover();
    }

    public interface IForeColorOnHover
    {
        Color ForeColorOnHover { get; set; }

        void SetForeColorOnHover();
    }

    public interface IBackColorOnClick
    {
        Color BackColorOnClick { get; set; }

        void SetBackColorOnClick();
    }

    public interface IForeColorOnClick
    {
        Color ForeColorOnClick { get; set; }

        void SetForeColorOnClick();
    }

    public interface IBackColorOnEnter
    {
        Color BackColorOnEnter { get; set; }

        void SetBackColorOnEnter();
    }

    public interface IForeColorOnEnter
    {
        Color ForeColorOnEnter { get; set; }

        void SetForeColorOnEnter();
    }

    public interface IBackColorOnLeave
    {
        Color BackColorOnLeave { get; set; }

        void SetBackColorOnLeave();
    }

    public interface IForeColorOnLeave
    {
        Color ForeColorOnLeave { get; set; }

        void SetForeColorOnLeave();
    }

    public interface IBackColorOnCheck
    {
        Color BackColorOnCheck { get; set; }
    }

    public interface IForeColorOnCheck
    {
        Color ForeColorOnCheck { get; set; }
    }

    public interface IBackColorOnUncheck
    {
        Color BackColorOnUncheck { get; set; }
    }

    public interface IForeColorOnUncheck
    {
        Color ForeColorOnUncheck { get; set; }
    }
}