using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformcollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Colision del personaje con la plataforma, para que cuando este sobre el el jugador, vaya sobre la plataforma, y se mueva con ella
        Player p = collision.GetComponent<Player>();
        if(p)
        {
            p.gameObject.transform.parent = transform.parent;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Player p = collision.GetComponent<Player>();
        if (p)
        {
            p.gameObject.transform.parent = null;

        }
    }
}