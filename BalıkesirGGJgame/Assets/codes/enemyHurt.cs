using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHurt : MonoBehaviour
{
    private enemyHp hp;
    void Start()
    {
        hp = GetComponent<enemyHp>();
    }

    void Update()
    {
        destroyed();
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        hp.bossDamage(1);
    }
    
    private void destroyed() 
    {
        if (hp.hp <= 0) 
        {
            gameObject.SetActive(false);
        }
    }
}
