using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioClip CoinSound;
    [Range(0, 1)]
    public float volumeMusic;
    [SerializeField] private float AmountOfPoints;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Al pasar por encima de la moneda se destruya
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.AddPunt(AmountOfPoints);
            Destroy(this.gameObject);
            AudioManager.instance.PlayAudio(CoinSound, volumeMusic);
        }
    }
}
    
