using System.Collections.Generic;
using Models;
using Solitaire.Models;
namespace Services.Interfaces
{
    public interface IHintService
    {
        Pile CheckPilesForMove(IList<Pile> piles, Card card);
        Pile FindValidMove(Card card);
        Hint GetHint();
    }
}