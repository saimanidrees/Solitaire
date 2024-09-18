using Models;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
namespace Presenters.UI
{
    public class HomePresenter : OrientationAwarePresenter
    {
        [SerializeField]
        private Button _buttonNewMatch;

        [Inject]
        private readonly Game _game;

        protected override void Start()
        {
            base.Start();
            _game.NewMatchCommand.BindTo(_buttonNewMatch).AddTo(this);
        }
        protected override void OnOrientationChanged(bool isLandscape)
        {
            Debug.Log("Orientation Changed");
        }
    }
}