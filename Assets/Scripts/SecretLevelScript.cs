using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretLevelScript : MonoBehaviour
{
    
    public Rigidbody2D rigidPlayer;

    

    
    void Start ()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collidedWithThis)
    {
        Debug.Log(collidedWithThis.transform.tag);
        if (collidedWithThis.transform.tag == "Player")
        {
            Debug.Log("Secret Level!");
            SceneManager.LoadScene(sceneName:"Secret");
        }
    }
}
