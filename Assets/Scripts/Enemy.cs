using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ }
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
        ObjectToFollow = GameObject.FindGameObjectWithTag(Tag).GetComponent<Transform>();// invocando al player
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectToFollow == null) //En caso de que no haya nada
            return;

        transform.position = Vector2.MoveTowards(transfrom.position, new Vector2(ObjectToFollow.transform.position.x, transform.position.y), Speed * Time.deltaTime);
        transform.up = ObjectToFollow.position - transfrom.position;
    }
}
