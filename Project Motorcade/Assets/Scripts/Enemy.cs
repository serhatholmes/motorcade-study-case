using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;
    private float distance;
    public float movSpeed;
    public float howClose;

    public bool isAlive=true;
    Animator anim;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

         anim = this.gameObject.GetComponent<Animator>();
         
    }

    
    void Update()
    {

        if(isAlive)
        {
            distance = Vector3.Distance(player.position, transform.position);
        }
        

        if(distance<=howClose)
        {
            anim.SetBool("Running",true);
            transform.LookAt(player);
            
            GetComponent<Rigidbody>().velocity = transform.forward * movSpeed;

            // can be destroyed after a while
            
        }

        

        //for attack
        if(distance <= 1.5f)
        {
            //do attack
            anim.SetBool("Attacking",true);
        }
    }

    void OnCollisionEnter(Collision col) {
            if(col.gameObject.CompareTag("Player"))
            {
                
                Destroy(gameObject);
                isAlive = false;
            }
        }

    
}
