using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;

    public int desiredLane = 1; // 0-1-2 lanes
    public float laneDistance = 4;

    public Rigidbody rb;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.z = forwardSpeed;

        if(SwipeManager.swipeRight)
        {
           
            desiredLane++;
            if(desiredLane==3)
            {
                desiredLane=2;
            }
        }
         if(SwipeManager.swipeLeft)
        {
            
            desiredLane--;
            
            if(desiredLane==-1)
            {
                desiredLane=0;
            }
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y *transform.up;
    
        if(desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if(desiredLane ==2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.fixedDeltaTime*90);
        
    }


    private void FixedUpdate() 
    {
        controller.Move(direction*Time.fixedDeltaTime);
    }
}
