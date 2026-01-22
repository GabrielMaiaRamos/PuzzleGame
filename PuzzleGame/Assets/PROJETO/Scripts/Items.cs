//logica dos objetos / coletaveisusing Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyItems : Interactable
{
    [Header("Tipo de Objeto Interativo")]
    [SerializeField] bool Catchable;
    [SerializeField] bool PopUp;

    public override void OnInteract()
    {
        base.OnInteract();
        if (Catchable)
        {
            gameObject.SetActive(false);
        }
    }
}
