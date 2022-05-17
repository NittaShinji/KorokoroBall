using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccellFiled : MonoBehaviour
{
    public float power = 3;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody otherRigidbody = other.gameObject.GetComponent<Rigidbody>();
        if(otherRigidbody != null)
        {
            otherRigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }
    }
}
