using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2prefab : MonoBehaviour
{
    //Declaramos las variables
    public GameObject Player2;
    private Animator animator2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Indicamos que al pulsar el click izquierdo se ivoque a nuestro player2
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clon1 = Instantiate(Player2, transform.position, Quaternion.identity);
            clon1.GetComponent<Player2>();
            animator2.Play("Spawn");

        }
    }
}