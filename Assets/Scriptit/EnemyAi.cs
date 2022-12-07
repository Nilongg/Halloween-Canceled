using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform player;
    public Rigidbody enemyRb;

    public float chasingRange = 20f;
    public float chasingSpeed = 2f;

    private bool chasing;
    private Animator anim;



    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(player.position, transform.position) < chasingRange)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, player.position, chasingSpeed * Time.fixedDeltaTime);
            enemyRb.MovePosition(pos);
            transform.LookAt(player);
            anim.SetBool("Chasing", true);
        }
        else
        {
            anim.SetBool("Chasing", false);       
        }
            
            

        
    }
}
