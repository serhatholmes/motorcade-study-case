using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{
        
    public GameObject winPanel;
    public GameObject loosePanel;

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }

        else if(collision.gameObject.CompareTag("Finish"))
        {
            winPanel.SetActive(true);
        }
    }
     
}
