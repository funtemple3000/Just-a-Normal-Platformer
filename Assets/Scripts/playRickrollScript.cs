using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playRickrollScript : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioClip audioClip;

    [SerializeField]
    float volume = 1f;

    public event EventHandler onRickroll;
    void OnCollisionEnter2D(Collision2D collidedWithThis)
    {
        Debug.Log(collidedWithThis.transform.tag);
        if (collidedWithThis.transform.tag == "Player")
        {
            Debug.Log("Rickroll!");
            onRickroll?.Invoke(this, EventArgs.Empty);
            audioSource.PlayOneShot(audioClip, volume);
        }
    }
}
