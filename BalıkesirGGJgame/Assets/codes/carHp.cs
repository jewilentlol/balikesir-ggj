using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class carHp : MonoBehaviour
{
    public Image[] hearts;
    public int hp = 7;
    int maxhp = 7;
    public UIManager manager;
    public GameObject deathPanel;
    public GameObject car;
    void Start()
    {
        manager = GetComponent<UIManager>();
    }

    void Update()
    {
        antiBug();
        dead();
    }
    public void Damage(int amount) 
    {
        hearts[hp-1].enabled = false;
        hp--;
        
    }

    public void antiBug() 
    {
        if(hp > maxhp) 
        {
            hp = maxhp;
        }
    }
    public void dead() 
    {
        if (hp <= 0)
        {
            car.SetActive(false);
            Time.timeScale = 0.0f;
            deathPanel.SetActive(true);
        }
    }
}
