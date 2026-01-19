using Unity.VisualScripting;
using UnityEngine;

public class ArrowsControl : MonoBehaviour
{
    [Header("Setas")]
    [SerializeField] GameObject left;
    [SerializeField] GameObject right;
    [SerializeField] GameObject up;
    [SerializeField] GameObject down;
    [Header("Camera")]
    [SerializeField] GameObject cam;
    void FixedUpdate()
    {
        if (cam.transform.rotation.x < -50)
        {
            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
        }
        if (cam.transform.rotation.x > 50)
        {
            left.SetActive(false);
            right.SetActive(false);
            down.SetActive(false);
        }
    }
}
