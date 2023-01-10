using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
public float speed;
private Rigidbody2D rb;
private Animator animator;
SpriteRenderer rend;
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

void Movement()
{
    if(Input.GetKey(KeyCode.D))
    {
        animator.PLay("correr");
        rend.flipX = true;
        if (Transform.position.x < b.max.x)
            rb.velocity = new Vector2(speed, 0);
    }
else if(Input.GetKey(KeyCode.A))
        {
            animator.PLay("correr");
        rend.flipX = false;
            if (Transform.position.x > b.min.x)
                rb.velocity = new Vector2(-speed, 0);
        }
else
    {
        animator.Play("idle");
    }