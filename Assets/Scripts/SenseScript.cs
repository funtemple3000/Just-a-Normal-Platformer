using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenseScript : MonoBehaviour
{
    
    public event EventHandler onSensor;

    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioClip audioClip;

    [SerializeField]
    float volume = 1f;

    void OnCollisionEnter2D(Collision2D collidedWithThis)
    {
        Debug.Log(collidedWithThis.transform.tag);
        if (collidedWithThis.transform.tag == "Crate")
        {
            Debug.Log("Sense!");
            onSensor?.Invoke(this, EventArgs.Empty);
            audioSource.PlayOneShot(audioClip, volume);
        }
    }
}
