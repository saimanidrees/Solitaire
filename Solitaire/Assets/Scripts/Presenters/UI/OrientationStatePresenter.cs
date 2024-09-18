using Helpers;
using Models;
using Zenject;
namespace Presenters.UI
{
    public class OrientationStatePresenter : StateReactor<Orientation>
    {
        [Inject]
        private readonly OrientationState _orientationState;
        protected override StateModel<Orientation> Model => _orientationState;
        protected override void SetVisibility(bool isVisible)
        {
            gameObject.SetActive(isVisible);
        }
    }
}