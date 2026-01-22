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

    [Header("Variaveis de Acesso Global")]
    public static CameraMove Instance;
    public bool IsInCenter { get; private set; } = false;
    public static Vector3 CenterPointTarget { get; private set; } = new Vector3(0, 5, 0); //talvez usar pra mudar de fase (cubo)

    private float timer = 0;

    //qualquer referencia a instancia sera diretamente ligada a esse script
    private void Awake()
    {
        Instance = this;
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }
    public void SetCenterState(bool state)
    {
        //se o estado ja for esse, nao faz nada
        if (IsInCenter == state) return;
        //se for diferente, troca
        IsInCenter = state;

        //dependendo do estado, deve fazer algumas coisas

        //pra ficar no centro, coloca a para o centro atual (CenterPointTarget) e zera a rotacao x e z, mantendo o y (direcao do olho)
        if (IsInCenter == true)
        {
            camTarget.transform.SetPositionAndRotation(CenterPointTarget, Quaternion.Euler(0, camTarget.transform.eulerAngles.y, 0));
            ChangeVisibleArrows(0);
        }
    }

    //funcao pra qualquer outro script poder trocar o centro atual (cubo atual)
    public void CurrentCenterPoint(Vector3 vector)
    {
        CenterPointTarget = vector;
    }

    public void ChangeVisibleArrows(float occasion)
    {
        //so consegue mexer nas setas SE a camera estiver no centro
        if (IsInCenter)
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

    public void ReturnEsc()
    {
        if (IsInCenter == false)
        {
            //zera as rotacoes do x e z apenas, mantendo a "direcao do olhar" igual
            SetCenterState(true);


        }
    }
}