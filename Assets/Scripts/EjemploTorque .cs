using UnityEngine;
using System.Collections;

public class EjemploTorque : MonoBehaviour
{
    public float torque = 1000f;

    public Rigidbody rigidbodyObject;

    void Start()
    {
        rigidbodyObject = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horitzontal") * torque * Time.deltaTime;

        rigidbodyObject.AddTorque(transform.forward * h);
    }
}