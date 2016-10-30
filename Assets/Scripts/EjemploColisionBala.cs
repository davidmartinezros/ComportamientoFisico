using UnityEngine;
using System.Collections;

public class EjemploColisionBala : MonoBehaviour
{
    public bool golpeado = false;

    public Material materialGolpeado;

    public Renderer rendererObjecto;

    void Start()
    {
        rendererObjecto = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(!golpeado)
        {
            if(collision.gameObject.tag.Equals("Obstaculo"))
            {
                rendererObjecto.sharedMaterial = materialGolpeado;

                golpeado = true;
            }
        }
    }
}