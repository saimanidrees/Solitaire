using System.Collections.Generic;
using Models;
using Presenters;

namespace Services.Interfaces
{
    public interface ICardSpawner
    {
        IList<CardPresenter> Cards { get; }
        void Despawn(CardPresenter card);
        void DespawnAll();
        IList<CardPresenter> MakeCopies(IList<Card> cards);
        CardPresenter MakeCopy(Card card);
        CardPresenter Spawn(Card.Suits suit, Card.Types type);
        void SpawnAll();
    }
}