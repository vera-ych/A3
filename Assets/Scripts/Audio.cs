using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource Sound;
    public AudioSource SecondSound;
    // Start is called before the first frame update
    void Start()
    {
        Sound = GetComponent <AudioSource >();
        Sound.Play();  
    }

    // Update is called once per frame
    void Update()
    {
        audioswitch();
    }
    void audioswitch()
    {
        if (Sound.isPlaying == false)
        {
            if (SecondSound.isPlaying == false)
            {
                SecondSound.Play();
            }
        }
    }
}
