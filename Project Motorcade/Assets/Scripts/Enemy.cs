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

    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {

        if(isAlive)
        {
            distance = Vector3.Distance(player.position, transform.position);
        }
        

        if(distance<=howClose)
        {
            transform.LookAt(player);
            GetComponent<Rigidbody>().velocity = transform.forward * movSpeed;

            // can be destroyed after a while
            
        }

        

        //for attack
        if(distance <= 1.5f)
        {
            //do attack
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
