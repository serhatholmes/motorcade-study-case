using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMagn : MonoBehaviour
{
    public GameObject startPanel;
    private void Start() 
    {
        Time.timeScale=0.0f;
    }

    public void StartGame()
    {
        Time.timeScale=1.0f;
        startPanel.SetActive(false);
    }
    public GameObject pausePanel;
    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0.0f;
        
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }



}
