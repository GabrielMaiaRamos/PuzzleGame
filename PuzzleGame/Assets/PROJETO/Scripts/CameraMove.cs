using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour

{
    [Header("Setas")]
    [SerializeField] GameObject ArrowLeft;
    [SerializeField] GameObject ArrowRight;
    [SerializeField] GameObject ArrowUp;
    [SerializeField] GameObject ArrowDown;

    [Header("Target da Camera")]

    [SerializeField] GameObject camTarget;
    [Header("Direcoes de Rotacao")]
    [SerializeField] bool left;
    [SerializeField] bool right;
    [SerializeField] bool up;
    [SerializeField] bool down;
    private float timer = 0;
    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }

    public void OnClick()
    {
        if (timer >= 1.5)
        {
            Change();
            timer = 0;
        }
    }
    private void Change()
    {
        if (left)
            //rotaciona o target de forma instantanea, mas com a pacote Cinemachine, a camera acompanha
            //esse objeto (target) de forma suave ate chegar a posicao dele.
            camTarget.transform.Rotate(0, -90, 0, Space.World);
        else if (right)
            camTarget.transform.Rotate(0, 90, 0, Space.World);
        else if (up)
            camTarget.transform.Rotate(-90, 0, 0, Space.Self);
        else if (down)
            camTarget.transform.Rotate(90, 0, 0, Space.Self);

        Debug.Log(camTarget.transform.eulerAngles.x);
        if (camTarget.transform.eulerAngles.x > 265 && camTarget.transform.eulerAngles.x < 285)
        {
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
            ArrowUp.SetActive(false);
        }
        else if (camTarget.transform.eulerAngles.x > 85 && camTarget.transform.eulerAngles.x < 95)
        {
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
            ArrowDown.SetActive(false);
        }
        else
        {
            ArrowLeft.SetActive(true);
            ArrowRight.SetActive(true);
            ArrowUp.SetActive(true);
            ArrowDown.SetActive(true);
        }
    }
}