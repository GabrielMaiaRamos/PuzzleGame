using UnityEngine;

//usar (Items : Interactable) significa que Items é orientado ao Interactable, ou seja,
//possui todas as funcoes e variaveis de Interactable (eh um filho)
public class Furnitures : Interactable
{
    [Header("Posicao da Camera")]
    [SerializeField] GameObject CamTarget;
    [SerializeField] Transform PointValue;

    [Header("Itens menores no movel")]
    [SerializeField] GameObject[] itemsIn;

    //sobreescreve a funcao OnInteract do script Interactable (pai)
    public override void OnInteract()
    {
        base.OnInteract();

    }
}