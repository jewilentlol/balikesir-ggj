using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHp : MonoBehaviour
{
    public int maxHp = 10;
    public int hp = 10;
    public GameObject boss;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void bossDamage(int amount) 
    {
        hp--;
    }
}
