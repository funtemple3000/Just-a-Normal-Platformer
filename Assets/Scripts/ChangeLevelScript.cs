using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevelScript : MonoBehaviour
{
    
    public Rigidbody2D rigidPlayer;

    [SerializeField]
    int nextLevel;

    
    void Start ()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collidedWithThis)
    {
        Debug.Log(collidedWithThis.transform.tag);
        if (collidedWithThis.transform.tag == "Player")
        {
            Debug.Log("Next Level!");
            SceneManager.LoadScene(sceneName:$"Level {nextLevel}");
        }
    }
}
