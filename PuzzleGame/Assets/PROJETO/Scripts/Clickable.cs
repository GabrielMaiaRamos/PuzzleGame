using UnityEngine;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour, IPointerClickHandler
{
    //provavelmente vai ser descartado
    public void OnPointerClick(PointerEventData eventData)
    {
        GameData.door_level_1 = true;
    }
}
