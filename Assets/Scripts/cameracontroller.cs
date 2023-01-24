using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    //Declaramos las variables
    public float Followspeed = 2f;
    public float posinx = 1f;
    public Transform target;

    void Update()
    {
        //Indicamos la posicion de la camara y su nueva posicion
        Vector3 newpos = new Vector3(target.position.x + posinx, -0.5f, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, Followspeed * Time.deltaTime);
    }
}
