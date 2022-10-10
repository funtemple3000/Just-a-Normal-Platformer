using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rigidPlayer;
    public AudioSource bounceSound;
    public AudioClip clip;
    public float volume = 1f;
    
    void Start ()
    {
        //rigidPlayer = transform.GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collidedWithThis)
    {
        Rigidbody2D rigidObject = collidedWithThis.transform.GetComponent<Rigidbody2D>();
        Debug.Log(collidedWithThis.transform.tag);
        if (collidedWithThis.transform.tag == "Player" || collidedWithThis.transform.tag == "Crate")
        {
            Debug.Log("Collided!");
            rigidObject.velocity = transform.up * speed;
            bounceSound.PlayOneShot(clip, volume);
        }
    }
    
}
