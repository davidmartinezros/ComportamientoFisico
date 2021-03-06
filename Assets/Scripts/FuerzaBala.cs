using UnityEngine;
using System.Collections;

public class FuerzaBala : MonoBehaviour
{
    public Rigidbody rigidbodyObject;

    public LineRenderer lineRendererObject;

    public EjemploRaycast ejemploRaycastObject;

    public int fuerza = 1;

    public bool lanzado = false;

    // Use this for initialization
    void Start ()
	{
		rigidbodyObject= GetComponent<Rigidbody>();

        lineRendererObject = GetComponent<LineRenderer>();

        ejemploRaycastObject = GetComponent<EjemploRaycast>();

    }
	
	// Update is called once per frame
	void Update ()
	{
        if (!lanzado)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rigidbodyObject.AddForce(transform.forward * fuerza);

                if (lineRendererObject)
                {
                    lineRendererObject.enabled = false;
                }

                if (ejemploRaycastObject)
                {
                    ejemploRaycastObject.enabled = false;
                }

                lanzado = true;
            }
        }
	}
}

