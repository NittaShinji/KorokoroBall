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
        //ぶつかってきたオブジェクト
        if(other.gameObject.tag == "Player")
        {
            //コインを持っているゲームオブジェクト
            Destroy(gameObject);
        }
    }
}
