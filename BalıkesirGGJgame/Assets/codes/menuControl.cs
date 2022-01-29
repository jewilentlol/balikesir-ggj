using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuControl : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Quit() 
    {
        Application.Quit();
    }
    public void playMethod() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
