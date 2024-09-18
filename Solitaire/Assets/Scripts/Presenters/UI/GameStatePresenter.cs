using Helpers;
using Models;
using UnityEngine;
using Zenject;

namespace Presenters.UI
{
    [RequireComponent(typeof(Canvas))]
    public class GameStatePresenter : StateReactor<Game.State>
    {
        [Inject] private readonly GameState _gameState;

        private Canvas _canvas;

        protected override StateModel<Game.State> Model => _gameState;

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