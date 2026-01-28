using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
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
        rend.material.color = highlightColor;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        rend.material.color = original;
    }
    //uma funcao VIRTUAL significa que pode ser alterada por outros arquivos (filhos) usando override
    public void OnPointerClick(PointerEventData eventData)
    {
        OnInteract();
    }
    public virtual void OnInteract()
    {
        Debug.Log("Interagiu com " + ObjectName);
    }
    
}