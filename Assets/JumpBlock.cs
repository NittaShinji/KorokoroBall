using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    public float power = 8;
    public Vector3 jumpAngle = new Vector3(0, 1, 1);
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody otherRigidbody = other.gameObject.GetComponent <Rigidbody>();
        if (otherRigidbody != null)
        {
            otherRigidbody.velocity = jumpAngle.normalized * power;
        }
    }
}
