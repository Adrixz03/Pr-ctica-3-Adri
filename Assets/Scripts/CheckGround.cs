using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    //Para comprobar si esta en el suelo y si esta en el suelo que haga el salto
    public static bool IsGrounded;

private void OnTriggerEnter2D(Collider2D collision)
    {
        IsGrounded = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsGrounded = false;

    }

}
