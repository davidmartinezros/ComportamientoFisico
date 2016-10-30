using UnityEngine;
using System.Collections;

public class EjemploRaycast : MonoBehaviour
{
    public Material material;

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            print("Found an object - distance: " + hit.distance);
            hit.collider.GetComponent<Renderer>().material = material;
        }
    }
}