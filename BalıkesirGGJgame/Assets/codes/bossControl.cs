using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossControl : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private float maxRange;
    [SerializeField] private float minRange;

    void Start()
    {
        target = FindObjectOfType<basicMovement>().transform;
    }


    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= maxRange && Vector3.Distance(target.position, transform.position) >= minRange) 
        {
            followPlayer();
        }
    }
    public void followPlayer() 
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        
    }
}
