using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterHit : MonoBehaviour
{
    private carHp hp;
    [SerializeField] private GameObject hitCollider; 
    
    void Start()
    {
        hp = GetComponent<carHp>();
    }

    void Update()
    {
        carHit();
    }
    public void carHit() 
    {
        if (Input.GetKeyDown(KeyCode.T) && hitCollider.activeSelf == false) 
        {
            hitCollider.SetActive(true);
            Invoke("colliderKapat",0.2f);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        hp.Damage(1);
    }
    public void colliderKapat() 
    {
        hitCollider.SetActive(false);
    }
}
