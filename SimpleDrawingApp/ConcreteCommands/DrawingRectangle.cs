using SimpleDrawingApp.Commands;
using SimpleDrawingApp.Receivers;
using System.Drawing;

namespace SimpleDrawingApp.ConcreteCommands
{
    class DrawingRectangle : IDraw
    {
        private Drawing _drawing;
        private Graphics _graphics;
        private Color _color;
        private Color _transparentColor = Color.White;
        private Rectangle _rectangle;

        public DrawingRectangle(Drawing drawing, Graphics graphics, Color color, Rectangle rectangle)
        {
            _drawing = drawing;
            _color = color;
            _graphics = graphics;
            _rectangle = rectangle;
        }

        public void Execute()
        {
            _drawing?.DrawRectangle(_graphics, _color, _rectangle);
        }

        public void Unexecute()
        {
            _drawing?.DrawRectangle(_graphics, _transparentColor, _rectangle);
        }
    }
}
