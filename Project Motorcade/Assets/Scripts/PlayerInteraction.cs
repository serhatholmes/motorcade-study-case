using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    //for limo
    public int health=100;

    public GameObject winPanel;
    public GameObject loosePanel;

    private void OnCollisionEnter(Collision col) {
        
        if(col.gameObject.CompareTag("enemy"))
        {
            health = health-50;
        }

        if(col.gameObject.CompareTag("Finish"))
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private void Update() {

            if(health<=0)
            {
                loosePanel.SetActive(true);
                Destroy(gameObject);
            }
    }
}
