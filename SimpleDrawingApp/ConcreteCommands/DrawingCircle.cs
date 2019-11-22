using SimpleDrawingApp.Commands;
using SimpleDrawingApp.Receivers;
using System.Drawing;

namespace SimpleDrawingApp.ConcreteCommands
{
    class DrawingCircle : IDraw
    {
        private Drawing _drawing;
        private Graphics _graphics;
        private Color _color;
        private Color _transparentColor = Color.White;
        private Point _position;
        private float _radius;

        public DrawingCircle(Drawing drawing, Graphics graphics, Color color, Point position, float radius)
        {
            _drawing = drawing;
            _graphics = graphics;
            _color = color;
            _position = position;
            _radius = radius;
        }

        public void Execute()
        {
            _drawing?.DrawCircle(_graphics, _color, _position, _radius);
        }

        public void Unexecute()
        {
            _drawing?.DrawCircle(_graphics, _transparentColor, _position, _radius);
        }
    }
}
