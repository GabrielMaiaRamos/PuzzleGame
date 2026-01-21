using Unity.VisualScripting;
using UnityEngine;

//usar (Items : Interactable) significa que Items é orientado ao Interactable, ou seja,
//possui todas as funcoes e variaveis de Interactable (eh um filho)
public class Furnitures : Interactable
{
    [Header("Posicao da Camera")]
    [SerializeField] GameObject MainCam;
    [SerializeField] GameObject CamTarget;
    [SerializeField] Transform PointValue;

    [Header("Itens menores no movel")]
    [SerializeField] GameObject[] itemsIn;

    private void HideArrows()
    {
        GameData.IsInCenter = false;
        Camera.main.GetComponent<CameraMove>().ChangeVisibleArrows(0);
    }
    //sobreescreve a funcao OnInteract do script Interactable (pai)
    public override void OnInteract()
    {
        base.OnInteract();

        HideArrows();

        CamTarget.transform.SetPositionAndRotation(PointValue.position, PointValue.rotation);
        //mesma coisa que:
        //CamTarget.transform.position = PointValue.position;
        //CamTarget.transform.rotation = PointValue.rotation;
    }
}