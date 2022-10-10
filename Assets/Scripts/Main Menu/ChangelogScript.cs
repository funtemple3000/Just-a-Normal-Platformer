using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangelogScript : MonoBehaviour
{
    public void changelog()
    {
        SceneManager.LoadScene("Changelog");
    }
    public void levelselect()
    {
        SceneManager.LoadScene("Level Select");
    }
    
}
