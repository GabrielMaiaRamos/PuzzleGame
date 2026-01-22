using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string ObjectName;

    //uma funcao VIRTUAL significa que pode ser alterada por outros arquivos (filhos) usando override
    public virtual void OnInteract()
    {
        Debug.Log("Interagiu com " + ObjectName);
    }
}