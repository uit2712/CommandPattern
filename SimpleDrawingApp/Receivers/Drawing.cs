using System.Drawing;

namespace SimpleDrawingApp.Receivers
{
    class Drawing
    {
        private Pen _pen = null;

        public Drawing()
        {
            
        }

        public void DrawRectangle(Graphics graphics, Color color, Rectangle rectangle)
        {
            if (graphics == null || rectangle == null)
                return;

            _pen = new Pen(color);
            graphics.DrawRectangle(_pen, rectangle);
        }

        public void DrawCircle(Graphics graphics, Color color, Point position, float radius)
        {
            if (graphics == null)
                return;

            _pen = new Pen(color);
            graphics.DrawEllipse(_pen, position.X, position.Y, radius, radius);
        }
    }
}
