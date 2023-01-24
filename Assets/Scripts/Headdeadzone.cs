using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headdeadzone : MonoBehaviour
{
    void Start()
    {
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //Deadzone de la cabeza del enemigo
            if (collision.GetComponent<Player>())
            {

                Destroy(gameObject.transform.parent.gameObject);


            }
        }
    }
