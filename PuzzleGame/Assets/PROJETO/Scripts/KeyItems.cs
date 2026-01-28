//logica dos objetos / coletaveisusing Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class KeyItems : Interactable, IPointerClickHandler
{
    [Header("Tipo de Objeto Interativo")]
    [SerializeField] bool Catchable;
    [SerializeField] bool PopUp;

    public override void OnInteract()
    {
        base.OnInteract();
        if (Catchable)
        {
            Destroy(gameObject);
        }
    }
}
