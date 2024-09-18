using UniRx;
namespace Services.Interfaces
{
    public interface IPointsService
    {
        IntReactiveProperty Points { get; }
        void Add(int value);
        void Reset();
        void Set(int value);
    }
}