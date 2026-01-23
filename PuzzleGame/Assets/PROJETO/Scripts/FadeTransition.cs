using Unity.VisualScripting;
using UnityEngine;

public class FadeTransition : MonoBehaviour
{
    [Header("Variaveis de Acesso Global")]
    public static FadeTransition Instance;

    [SerializeField] CanvasGroup canvasGroup;
    private float fadeSpeed = 2.0f;

    private void Awake()
    {
        Instance = this;
    }

    public void FadeScreen()
    {
        Debug.Log("Fadee");
        //impede clicar em qualquer coisa
        canvasGroup.blocksRaycasts = true;

        //aparece e some a tela preta
        while (canvasGroup.alpha < 1)
            canvasGroup.alpha += Time.deltaTime * fadeSpeed;
        while (canvasGroup.alpha > 0)
            canvasGroup.alpha -= Time.deltaTime * fadeSpeed;

        canvasGroup.blocksRaycasts = false;
    }
}
