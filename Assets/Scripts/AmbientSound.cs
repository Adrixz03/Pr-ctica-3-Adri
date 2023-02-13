using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip ambientSound;
    [Range(0, 1)]
    public float volumeMusic;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayAudioOnLoop(ambientSound, volumeMusic);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
