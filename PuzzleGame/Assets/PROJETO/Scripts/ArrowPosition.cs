using Unity.VisualScripting;
using UnityEngine;

public class ArrowPosition : MonoBehaviour
{
    [Header("Direcao das Setas")]
    [SerializeField] bool left;
    [SerializeField] bool right;
    [SerializeField] bool up;
    [SerializeField] bool down;

    void FixedUpdate()
    {
        if (left)
        {
            transform.position = new Vector2(25, Screen.height / 2.0f);
        }
        if (right)
        {
            transform.position = new Vector2(Screen.width - 25, Screen.height / 2.0f);
        }
        if (down)
        {
            transform.position = new Vector2(Screen.width / 2.0f, 25);
        }
        if (up)
        {
            transform.position = new Vector2(Screen.width / 2.0f, Screen.height - 25);
        }
    }
}
