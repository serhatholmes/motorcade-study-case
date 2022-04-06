using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    //for limo
    public int health=100;

    private void OnCollisionEnter(Collision col) {
        
        if(col.gameObject.CompareTag("enemy"))
        {
            health = health-50;
        }
    }

    private void Update() {

            if(health<=0)
            {
                Destroy(gameObject);
            }
    }
}
