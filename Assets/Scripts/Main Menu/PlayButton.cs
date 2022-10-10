using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void onPressPlay()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void onPressSkins()
    {
        SceneManager.LoadScene("Skins");
    }
}
