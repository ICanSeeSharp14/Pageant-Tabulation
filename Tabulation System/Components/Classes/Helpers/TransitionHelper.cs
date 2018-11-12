using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Tabulation_System.Commons.Enums;

namespace Tabulation_System.Components.Classes.Helpers
{
    public static class TransitionHelper
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public static void SetEllipse<TControl>(TControl control, int ellipse) where TControl : Control
        {
            control.Region =
                Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width + 1, control.Height + 1, ellipse, ellipse));
        }

        public static void GradientPaint<TControl>(Gradient<TControl> gradient) where TControl : Control
        {
            switch (gradient.ColorCombination)
            {
                case ColorCombination.SoloColor:
                    SetSoloColorGradient(gradient.Sender,
                        gradient.ColorA);
                    break;
                case ColorCombination.DualColor:
                    SetDualColorGradient(gradient.Sender,
                        gradient.ColorA,
                        gradient.ColorB,
                        gradient.GradientAngle);
                    break;
                case ColorCombination.TriColor:
                    SetTriColorGradient(gradient.Sender,
                        gradient.ColorA,
                        gradient.ColorB,
                        gradient.ColorC,
                        gradient.GradientAngle);
                    break;
            }
        }

        private static void SetSoloColorGradient(Control ctrl, Color colorA)
        {
            ctrl.BackColor = colorA;
            ctrl.BackgroundImage = null;
        }

        private static void SetDualColorGradient(Control ctrl, Color colorA, Color colorB, int gradientAngle)
        {
            var colorBlend = new ColorBlend(3)
            {
                Colors = new[] {colorA, colorB},
                Positions = new[] {0f, 1.0f}
            };

            CreateGradientGraphics(ctrl, colorBlend, gradientAngle);
        }

        private static void SetTriColorGradient(Control ctrl, Color colorA, Color colorB, Color colorC,
            int gradientAngle)
        {
            var colorBlend = new ColorBlend(3)
            {
                Colors = new[] {colorA, colorB, colorC},
                Positions = new[] {0f, 0.5f, 1.0f}
            };

            CreateGradientGraphics(ctrl, colorBlend, gradientAngle);
        }

        private static void CreateGradientGraphics(Control ctrl, ColorBlend colorBlend, int gradientAngle)
        {
            var gradientBrush =
                new LinearGradientBrush(ctrl.ClientRectangle, Color.White, Color.Black, gradientAngle)
                {
                    InterpolationColors = colorBlend
                };


            var bitmap = new Bitmap(ctrl.Width, ctrl.Height);

            var graphics = Graphics.FromImage(bitmap);

            graphics.FillRectangle(gradientBrush, ctrl.ClientRectangle);

            ctrl.BackgroundImage = bitmap;
            ctrl.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}