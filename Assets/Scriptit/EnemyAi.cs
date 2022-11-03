using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform player;
    public Rigidbody enemyRb;

    public float chasingRange = 20f;
    public float startChaseRange = 10f;
    public float chasingSpeed = 2f;



    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(player.position, transform.position) < startChaseRange)
        {
            if (Vector3.Distance(player.position, transform.position) < chasingRange)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, player.position, chasingSpeed * Time.fixedDeltaTime);
                enemyRb.MovePosition(pos);
                transform.LookAt(player);
            }
            
            

        }
    }
}
