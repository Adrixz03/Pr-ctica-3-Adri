using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headdeadzone : MonoBehaviour
{
    [SerializeField] private float AmountOfPoints;
    public AudioClip KillSound;
    [Range(0, 1)]
    public float volumeMusic;
    void Start()
    {
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //Deadzone de la cabeza del enemigo
            if (collision.GetComponent<Player>())
            {
            GameManager.instance.AddPunt(AmountOfPoints);
            Destroy(gameObject.transform.parent.gameObject);
            AudioManager.instance.PlayAudio(KillSound, volumeMusic);
            }
        }
    }
