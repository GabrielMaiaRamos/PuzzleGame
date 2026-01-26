using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string ObjectName;
    private Color original;
    private Renderer rend;
    private Color highlightColor = Color.yellow;

    void Start() 
    { 
        rend = GetComponent<Renderer>(); 
        original = rend.material.color; 
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("apontei");
        rend.material.color = highlightColor;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("sai");
        rend.material.color = original;
    }
    //uma funcao VIRTUAL significa que pode ser alterada por outros arquivos (filhos) usando override
    public virtual void OnInteract()
    {
        Debug.Log("Interagiu com " + ObjectName);
    }
    
}