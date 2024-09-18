using System.Collections.Generic;
using Commands;
using Services.Interfaces;
using UniRx;

namespace Services
{
    public class CommandService : ICommandService
    {
        private readonly Stack<ICommand> _commands = new();
        public BoolReactiveProperty CanUndo { get; } = new();

        public void Add(ICommand command)
        {
            if (command == null)
                return;

            _commands.Push(command);
            CanUndo.Value = _commands.Count > 0;
        }

        public void Undo()
        {
            if (_commands.Count > 0)
            {
                _commands.Pop().Undo();
                CanUndo.Value = _commands.Count > 0;
            }
        }

        public void Reset()
        {
            _commands.Clear();
            CanUndo.Value = false;
        }
    }
}
