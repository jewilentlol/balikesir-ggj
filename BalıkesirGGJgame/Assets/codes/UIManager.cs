using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject deathPanel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }
    public void deathpanelMethod() 
    {
        Time.timeScale = 0.0f;
        deathPanel.SetActive(true);
    }
    public void Quit() 
    {
        Application.Quit();
    }
}

