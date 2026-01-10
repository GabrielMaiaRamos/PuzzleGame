using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour

{
    [Header("Target da Camera")]
    [SerializeField] GameObject cam;
    [Header("Direcoes de Rotacao")]
    [SerializeField] bool left;
    [SerializeField] bool right;
    [SerializeField] bool up;
    [SerializeField] bool down;

    public void OnClick()
    {
        Debug.Log("aa");
        if (left)
            //rotaciona o target de forma instantanea, mas com a pacote Cinemachine, a camera acompanha
            //esse objeto (target) de forma suave ate chegar a posicao dele.
            cam.transform.Rotate(0, -90, 0, Space.World);
        else if (right)
            cam.transform.Rotate(0, 90, 0, Space.World);
        else if (up)
            cam.transform.Rotate(-90, 0, 0, Space.Self);
        else if (down)
            cam.transform.Rotate(90, 0, 0, Space.Self);
    }
}