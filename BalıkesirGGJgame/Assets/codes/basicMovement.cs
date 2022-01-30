using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMovement : MonoBehaviour
{
    [SerializeField] private float hiz;
    [SerializeField] float dashSpeed;
    private float dashTime;
    private int dir;
    [SerializeField] float startDashTime;
    Rigidbody2D rb;
    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Hareket();
        Dash();
    }
    void Hareket() 
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(yatay*hiz,dikey*hiz);
        anim.SetFloat("velocity",Mathf.Abs(yatay)+Mathf.Abs(dikey));
        anim.SetFloat("moveX",yatay);
        anim.SetFloat("moveY",dikey);
    }
    void Dash() 
    {
        if (dir==0) 
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow)) 
            {
                dir = 1;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow)) 
            {
                dir = 2;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow)) 
            {
                dir = 3;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow)) 
            {
                dir = 4;
            }
        }
        else 
        {
            if(dashTime <= 0) 
            {
                dir = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else 
            {
                dashTime -= Time.deltaTime;
                if (dir==1) 
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                else if (dir==2) 
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
                else if (dir==3) 
                {
                    rb.velocity = Vector2.up * dashSpeed;
                }
                else if (dir==4) 
                {
                    rb.velocity = Vector2.down * dashSpeed;
                }
            }
        }
    }
}
