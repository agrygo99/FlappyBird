using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{

    public static AudioClip collisionSound, pointSound, flapSound, detectionSound;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //load soundFX
        collisionSound = Resources.Load<AudioClip>("Collision");
        pointSound = Resources.Load<AudioClip>("Point");
        flapSound = Resources.Load<AudioClip>("Flap");
        detectionSound = Resources.Load<AudioClip>("Detection");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch(clip)
        {
            //create an option for other components to use this soundFX
            case "Collision":
                audioSource.PlayOneShot (collisionSound);
            break;

            case "Point":
                audioSource.PlayOneShot (pointSound);
            break;
            
            case "Flap":
                audioSource.PlayOneShot (flapSound);
            break;

            case "Detection":
                audioSource.PlayOneShot (detectionSound);
            break;

        }
    }
}
