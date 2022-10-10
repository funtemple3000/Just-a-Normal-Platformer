using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterScript : MonoBehaviour
{
    [SerializeField]
    float newSpeed;

    void OnCollisionEnter2D(Collision2D collidedWithThis)
    {
        PlayerMovement player = collidedWithThis.transform.GetComponent<PlayerMovement>();
        Debug.Log(collidedWithThis.transform.tag);
        if (collidedWithThis.transform.tag == "Player")
        {
            Debug.Log("SPEED!");
            player.speed = newSpeed;
            
        }
    }
}
