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
            //‚Ç‚¿‚ç‚Ì‘‚«•û‚Å‚à‚æ‚¢
            otherRigidbody.velocity = Vector3.zero;
            otherRigidbody.angularVelocity = new Vector3(0, 0, 0);
        }
    }
}
