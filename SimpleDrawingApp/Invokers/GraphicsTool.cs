using SimpleDrawingApp.Commands;
using SimpleDrawingApp.Receivers;
using System.Collections.Generic;
using System.Drawing;

namespace SimpleDrawingApp.Invokers
{
    class GraphicsTool : IDraw
    {
        private Drawing _drawing = null;
        private List<IDraw> _commands = new List<IDraw>();
        private Color _color = Color.Red;

        public GraphicsTool(Drawing drawing)
        {
            _drawing = drawing;
        }

        public void AddCommand(IDraw command)
        {
            if (command != null)
                _commands.Add(command);
        }

        public void Execute()
        {
            IDraw command = GetLastCommand();
            command?.Execute();
        }

        public void Unexecute()
        {
            UnexecuteLastCommand();
            RedoAllCommands();
        }

        private void UnexecuteLastCommand()
        {
            IDraw command = GetLastCommand();
            command?.Unexecute();
            if (_commands.Count > 0)
                _commands.RemoveAt(_commands.Count - 1);
        }

        private void RedoAllCommands()
        {
            foreach (IDraw cmd in _commands)
                cmd?.Execute();
        }

        private IDraw GetLastCommand()
        {
            if (_commands.Count == 0)
                return null;

            return _commands[_commands.Count - 1];
        }
    }
}
