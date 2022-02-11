using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_PRG281_Music_Game
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>() 
        {
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607F8B",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A",
            "#5978BB",
            "#018790",
            "#0E3441",
            "#00B0AD",
            "#721D47",
            "#EA4833",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#8BC240",
            "#364D5B",
            "#0094BC",
            "#E4126B",
            "#43B76E",
            "#7BCFE9",
            "#B71c46"
        };
    }

    class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
 
