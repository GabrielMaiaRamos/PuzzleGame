using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteracts : MonoBehaviour
{
    void FixedUpdate()
    {
        //se apertar o botao esquerdo em qualquer momento:
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //cria um vetor 3D a partir do ponto em que o mouse estava durante o click
            Ray vector = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(vector, out hit))
            {
                //tenta coletar o script Interactable do objeto (caso tenha)
                Interactable item = hit.collider.GetComponent<Interactable>();
                //se tiver o script, ativa ele
                if (item != null)
                {
                    item.OnInteract();
                }
            }
        }
    }
}
