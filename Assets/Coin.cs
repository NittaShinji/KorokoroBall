using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //�Ԃ����Ă����I�u�W�F�N�g
        if(other.gameObject.tag == "Player")
        {
            //�R�C���������Ă���Q�[���I�u�W�F�N�g
            Destroy(gameObject);
        }
    }
}
