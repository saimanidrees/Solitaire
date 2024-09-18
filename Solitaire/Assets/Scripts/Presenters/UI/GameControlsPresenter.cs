using Models;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
namespace Presenters.UI
{
    public class GameControlsPresenter : OrientationAwarePresenter
    {
        [SerializeField] private Button _buttonHome;
        [SerializeField] private Button _buttonMatch;
        [SerializeField] private Button _buttonUndo;
        [SerializeField] private Button _buttonHint;

        [Inject] private readonly GameControls _gameControls;
        [Inject] private readonly GamePopup _gamePopup;
        private RectTransform _rectHint;
        private RectTransform _rectHome;
        private RectTransform _rectMatch;

        private RectTransform _rectUndo;

        private void Awake()
        {
            _rectHome = _buttonHome.GetComponent<RectTransform>();
            _rectMatch = _buttonMatch.GetComponent<RectTransform>();
            _rectUndo = _buttonUndo.GetComponent<RectTransform>();
            _rectHint = _buttonHint.GetComponent<RectTransform>();
        }

        protected override void Start()
        {
            base.Start();
            _gameControls.HomeCommand.BindTo(_buttonHome).AddTo(this);
            _gamePopup.MatchCommand.BindTo(_buttonMatch).AddTo(this);
            _gameControls.UndoCommand.BindTo(_buttonUndo).AddTo(this);
            _gameControls.HintCommand.BindTo(_buttonHint).AddTo(this);
        }
        protected override void OnOrientationChanged(bool isLandscape)
        {
            _rectHome.anchoredPosition = new Vector2(isLandscape ? -210 : -165, _rectHome.anchoredPosition.y);
            _rectMatch.anchoredPosition = new Vector2(isLandscape ? -70 : -55, _rectMatch.anchoredPosition.y);
            _rectUndo.anchoredPosition = new Vector2(isLandscape ? 70 : 55, _rectUndo.anchoredPosition.y);
            _rectHint.anchoredPosition = new Vector2(isLandscape ? 210 : 165, _rectHint.anchoredPosition.y);
        }
    }
}