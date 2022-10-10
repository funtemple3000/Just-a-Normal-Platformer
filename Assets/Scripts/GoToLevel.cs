using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{
    [SerializeField]
    int level;

    public void Level()
    {
        SceneManager.LoadScene($"Level {level}");
    }
}
