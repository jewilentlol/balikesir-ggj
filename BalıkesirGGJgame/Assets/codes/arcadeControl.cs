using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class arcadeControl : MonoBehaviour
{
    [SerializeField] GameObject pressE;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        pressE.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    private void OnTriggerStay2D(Collider2D other) 
    {
        pressE.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        pressE.SetActive(false);
    }
}   
