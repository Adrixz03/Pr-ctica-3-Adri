using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public Transform player;

    private float camerasize;
    private float cameraheight;
    // Start is called before the first frame update
    void Start()
    {
        camerasize = Camera.main.orthographicSize;
        cameraheight = camerasize * 2;
    }

    void CalculateCameraPosition()
    {
        
    }
}
