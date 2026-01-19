using UnityEngine;
using UnityEngine.EventSystems;

public class Key : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameData.door_level_1 = true;
    }
}
