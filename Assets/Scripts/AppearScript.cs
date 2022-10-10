using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearScript : MonoBehaviour
{
    [SerializeField]
    SenseScript sensor;

    [SerializeField]
    GameObject self;

    void Start()
    {
        self.SetActive(false);
        sensor.onSensor += appear;

    }

    private void appear(object sender, EventArgs e)
    {
        self.SetActive(true);
    }
}
