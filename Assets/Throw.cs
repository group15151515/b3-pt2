using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour
{
    public GameObject Bottle;
    Rigidbody rb;

    void Awake()
    {
        rb = Bottle.GetComponent<Rigidbody>();
    }

    public void ThrowObjectWithForce(float Power) {
        rb.AddForce(Vector3.forward * Power);
    }
}