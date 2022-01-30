using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class finalekran : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void finalEkran() 
    {
        SceneManager.LoadScene(0);
    }
    public void Quit() 
    {
        Application.Quit();
    }
}
