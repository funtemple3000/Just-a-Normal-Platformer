using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinScript : MonoBehaviour
{
    [SerializeField]
    int skinIndex;

    public void changeSkin()
    {
        PlayerSkin.playerSkin = skinIndex;
        Debug.Log($"Changed skin to {PlayerSkin.playerSkin}");
    }
}
