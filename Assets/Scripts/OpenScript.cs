using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript : MonoBehaviour
{
    [SerializeField]
    SenseScript sensor;

    [SerializeField]
    GameObject self;

    void Start()
    {
        sensor.onSensor += openDoor;
    }

    private void openDoor(object sender, EventArgs e)
    {
        self.SetActive(false);
    }
}
