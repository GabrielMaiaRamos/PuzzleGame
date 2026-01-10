using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour
{
    [SerializeField] GameObject cam;
    [SerializeField] bool left;
    public void OnClick()
    {
        
        if (left)
        {
            cam.transform.Rotate(Vector3.up * -90f / 5);
        }
        else
        {
            cam.transform.Rotate(Vector3.up * 90f / 5);
        }
    }
}
