using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private enemyHp hp;
    void Start()
    {
        hp = GetComponent<enemyHp>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        hp.bossDamage(1);
    }
}
