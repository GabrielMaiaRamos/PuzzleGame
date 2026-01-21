using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour

{
    [Header("Objetos das Setas")]
    [SerializeField] GameObject ArrowLeft;
    [SerializeField] GameObject ArrowRight;
    [SerializeField] GameObject ArrowUp;
    [SerializeField] GameObject ArrowDown;

    [Header("Target da Camera")]

    [SerializeField] GameObject camTarget;

    private float timer = 0;
    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }

    public void ChangeVisibleArrows(float occasion)
    {
        //so consegue mexer nas setas SE a camera estiver no centro
        if (GameData.IsInCenter)
        {
            if (occasion > 265 && occasion < 285)
            {
                ArrowLeft.SetActive(false);
                ArrowRight.SetActive(false);
                ArrowUp.SetActive(false);
            }
            else if (occasion > 85 && occasion < 95)
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
        else
        {
            ArrowLeft.SetActive(false);
            ArrowRight.SetActive(false);
            ArrowUp.SetActive(false);
            ArrowDown.SetActive(false);
        }
    }

    //rotaciona o target de forma instantanea, mas com a pacote Cinemachine, a camera acompanha
    //esse objeto (target) de forma suave ate chegar a posicao dele.
    public void ChangeRotation(string direction)
    {
        if (timer >= 1.2)
        {
            if (direction == "left")
                camTarget.transform.Rotate(0, -90, 0, Space.World);
            else if (direction == "right")
                camTarget.transform.Rotate(0, 90, 0, Space.World);

            else if (direction == "up")
            {
                camTarget.transform.Rotate(-90, 0, 0, Space.Self);
                ChangeVisibleArrows(camTarget.transform.eulerAngles.x);
            }
            else if (direction == "down")
            {
                camTarget.transform.Rotate(90, 0, 0, Space.Self);
                ChangeVisibleArrows(camTarget.transform.eulerAngles.x);
            }

            timer = 0;
        }
    }
}