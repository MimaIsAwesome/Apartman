using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioSource sound;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "stickL" || collider.tag == "stickR")
        {
            sound.Play();
        }
    }
}
