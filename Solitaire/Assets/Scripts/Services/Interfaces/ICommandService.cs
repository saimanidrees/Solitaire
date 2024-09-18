using Commands;
using UniRx;
namespace Services.Interfaces
{
    public interface ICommandService
    {
        BoolReactiveProperty CanUndo { get; }
        void Add(ICommand command);
        void Reset();
        void Undo();
    }
}