using Helpers;

namespace Models
{
    public enum Orientation
    {
        Unknown,
        Portrait,
        Landscape
    }

    public class OrientationState : StateModel<Orientation>
    {
        public OrientationState()
            : base(Orientation.Unknown) { }
    }
}
