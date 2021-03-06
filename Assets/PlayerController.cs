using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 10;
    public Rigidbody rigidbody;

    private Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }

        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }

        if (Input.GetKeyDown(KeyCode.Return) || transform.position.y <= -10)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.position = respawnPoint;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Checkpoint")
        {
            respawnPoint = other.transform.position;
        }

    }
}
