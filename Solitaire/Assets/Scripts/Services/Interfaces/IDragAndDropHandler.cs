using System.Collections.Generic;
using Models;
using UnityEngine.EventSystems;
namespace Services.Interfaces
{
    public interface IDragAndDropHandler
    {
        void BeginDrag(PointerEventData eventData, IList<Card> draggedCards);
        void Drag(PointerEventData eventData);
        void Drop();
        void EndDrag();
    }
}