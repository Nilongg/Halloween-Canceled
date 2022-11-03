using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlacement : MonoBehaviour
{

    private void Update()
    {
        if(GameManager.instance.placedPumpkins <= 0)
            GameManager.instance.placedPumpkins = 0;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EmptyPad")
        {
            GameManager.instance.placedPumpkins += 1;
            collision.gameObject.tag = "FullPad";
            DisablePhysics();
        }
        
        
    }
    private void DisablePhysics()
    {
        gameObject.layer = LayerMask.NameToLayer("Default");
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
    }

}
