using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOLscript : MonoBehaviour
{
    [SerializeField]
    playRickrollScript listen;

    [SerializeField]
    GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        self.SetActive(false);
        listen.onRickroll += show;
    }

    private void show(object sender, EventArgs e)
    {
        Debug.Log("Active!");
        self.SetActive(true);
    }
}
