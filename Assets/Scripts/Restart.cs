using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField]
    int levelnum;
    public void restart()
    {
        SceneManager.LoadScene(sceneName:$"Level {levelnum}");
    }
    public void secret()
    {
        SceneManager.LoadScene("Secret");
    }
}
