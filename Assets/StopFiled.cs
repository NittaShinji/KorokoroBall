using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFiled : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody otherRigidbody = other.gameObject.GetComponent<Rigidbody>();
        if (otherRigidbody != null)
        {
            //どちらの書き方でもよい
            otherRigidbody.velocity = Vector3.zero;
            otherRigidbody.angularVelocity = new Vector3(0, 0, 0);
        }
    }
}
