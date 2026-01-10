using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour

{
    [Header("Target da Camera // Direcao da Rotacao")]
    [SerializeField] GameObject cam;
    [SerializeField] bool left;

    public void OnClick()
    {
        if (left)
            //rotaciona o target de forma instantanea, mas com a pacote Cinemachine, a camera acompanha
            //esse objeto (target) de forma suave ate chegar a posicao dele.
            cam.transform.Rotate(0, -90, 0);
        else
            cam.transform.Rotate(0, 90, 0);
    }
}