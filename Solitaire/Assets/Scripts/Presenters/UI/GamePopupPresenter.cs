using Helpers;
using Models;
using UnityEngine;
using Zenject;

namespace Presenters.UI
{
    public class GamePopupPresenter : StateReactor<Game.Popup>
    {
        [Inject] private readonly GamePopup _gamePopup;

        private Canvas _canvas;

        protected override StateModel<Game.Popup> Model => _gamePopup;

        private void Awake()
        {
            _canvas = GetComponent<Canvas>();
        }

        protected override void SetVisibility(bool isVisible)
        {
            _canvas.enabled = isVisible;
        }
    }
}