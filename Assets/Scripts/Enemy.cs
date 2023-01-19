using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    private const string Tag = "Player";
    public Transform ObjectFollow = null;
    public float speed = 2;

private void OnCollisionEnter2D(Collision2D other)//metodo destroy
{
    if (other.collider.GetComponent<Player>())
    { 
        Destroy(other.gameObject);
    }
}

    // Start is called before the first frame update
    void Start()
    {
        ObjectFollow = GameObject.FindGameObjectWithTag(Tag).GetComponent<Transform>();// invocando al player
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectFollow == null) //En caso de que no haya nada
            return;

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(ObjectFollow.transform.position.x, transform.position.y), speed * Time.deltaTime);
        transform.up = ObjectFollow.position - transform.position;
    }
    
}