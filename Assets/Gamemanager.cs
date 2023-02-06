using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private float puntuacion;
    private float time;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)//comprueba q instance no tenga ningun tipo de informacion
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPunt(float value)
    {
        puntuacion += value;
    }
  
    public float GetPunt()
    { 
        return puntuacion;
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    public float GetTime()
    {
        return time;
    }
}
