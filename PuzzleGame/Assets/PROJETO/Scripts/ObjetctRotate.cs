using UnityEngine;
using UnityEngine.InputSystem;
public class ObjetctRotate : MonoBehaviour
{
    //provavelmente vai ser descartado
    private bool open = false;
    public void DoorInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (GameData.door_level_1)
            {
                if (open)
                {
                    gameObject.transform.Rotate(0, 110, 0);
                    open = false;
                }
                else
                {
                    gameObject.transform.Rotate(0, -110, 0);
                    open = true;
                }
                }
        }
    }
}
