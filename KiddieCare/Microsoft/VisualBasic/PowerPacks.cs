using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Microsoft.VisualBasic
{
    internal class PowerPacks
    {
        internal class LineShape
        {
            public int BorderWidth { get; internal set; }
            public string Name { get; internal set; }
            public int X1 { get; internal set; }
            public int X2 { get; internal set; }
            public int Y1 { get; internal set; }
            public int Y2 { get; internal set; }
            public DashStyle BorderStyle { get; internal set; }
        }

        internal class ShapeContainer
        {
            public Point Location { get; internal set; }
            public Padding Margin { get; internal set; }
            public string Name { get; internal set; }
            public object Shapes { get; internal set; }
        }

        internal class RectangleShape
        {
            public Point Location { get; internal set; }
            public string Name { get; internal set; }
            public Size Size { get; internal set; }
        }
    }
}