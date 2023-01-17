using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity;
    public float jumpSpeed;
    public LayerMask mascaraSuelo;
    public float rayDistance = 1.5f;
    private Animator animator;
    SpriteRenderer rend;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator= GetComponent<Animator>();
        rend= GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("running", true);
            rend.flipX = true;
            rb.velocity = new Vector3(-10, rb.velocity.y, 0);
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("running", true);
            rend.flipX = false;
            rb.velocity = new Vector3(10, rb.velocity.y, 0);

        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            animator.SetBool("running", false);
        }
        if (Input.GetKey(KeyCode.Space) && CheckGround.IsGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
    bool IsGrounded()
    {
        RaycastHit2D resultado = Physics2D.Raycast(transform.position,
            Vector2.down, rayDistance, mascaraSuelo.value);

        if (resultado)
        {
            Debug.Log(resultado.collider.gameObject.name);
            //if (resultado.collider.gameObject.CompareTag("suelo"))
           // {
                return true;
            //}
        }

        return false;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    }

} 



