using System.Drawing;
using System.Windows.Forms;
using Tabulation_System.Commons.Enums;

namespace Tabulation_System.Components
{
    public class Gradient<TControl> where TControl : Control
    {
        public Gradient(TControl sender, Color colorA, Color colorB, Color colorC, ColorCombination colorCombination,
            int gradientAngle = 45)
        {
            Sender = sender;
            ColorA = colorA;
            ColorB = colorB;
            ColorC = colorC;
            ColorCombination = colorCombination;
            GradientAngle = gradientAngle;
        }

        public TControl Sender { get; set; }
        public Color ColorA { get; set; }
        public Color ColorB { get; set; }
        public Color ColorC { get; set; }
        public ColorCombination ColorCombination { get; set; }
        public int GradientAngle { get; set; }
    }
}