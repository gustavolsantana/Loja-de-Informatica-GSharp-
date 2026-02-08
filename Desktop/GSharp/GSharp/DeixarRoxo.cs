using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSharp
{
    internal class DeixarRoxo
    {
        public class PurpleHoverRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (e.Item.Selected)
                {
                    // Cor roxa no hover
                    Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(95, 74, 139)), rect);
                }
                else
                {
                    base.OnRenderMenuItemBackground(e);
                }
            }
        }

    }
}
