using UniRx;
namespace Services.Interfaces
{
    public interface IMovesService
    {
        IntReactiveProperty Moves { get; }
        void Increment();
        void Reset();
    }
}