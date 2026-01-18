using UnityEngine;
using UnityEngine.InputSystem;
public class ObjetctRotate : MonoBehaviour
{
    public void DoorInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            gameObject.transform.Rotate(0, -10, 0);
        }
    }
}
