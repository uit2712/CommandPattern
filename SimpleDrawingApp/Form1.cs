using SimpleDrawingApp.ConcreteCommands;
using SimpleDrawingApp.Invokers;
using SimpleDrawingApp.Receivers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleDrawingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _graphicsTool = new GraphicsTool(_drawing);
            _graphics = pnlDrawingArea.CreateGraphics();
        }

        private Drawing _drawing = new Drawing();
        private Graphics _graphics = null;
        private GraphicsTool _graphicsTool = null;

        private void btnDraw_Click(object sender, EventArgs e)
        {
            AddCommands();
            _graphicsTool?.Execute();
        }

        private void AddCommands()
        {
            int x, y;

            Int32.TryParse(txtX.Text, out x);
            Int32.TryParse(txtY.Text, out y);

            switch (cbbShape.SelectedIndex)
            {
                case 0:
                    _graphicsTool?.AddCommand(new DrawingCircle(_drawing, _graphics, Color.Red, new Point(x, y), 150));
                    break;
                case 1:
                    _graphicsTool?.AddCommand(new DrawingRectangle(_drawing, _graphics, Color.Red, new Rectangle(x, y, 150, 150)));
                    break;
                default: break;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _graphicsTool?.Unexecute();
        }
    }
}
