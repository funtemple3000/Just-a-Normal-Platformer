
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternScript : MonoBehaviour
{
    public Transform playerPos;
    
    public PlayerMovement player;

    public AudioSource candySound;
    public AudioClip clip;
    public float volume = 1f;

    UnityEngine.Rendering.Universal.Light2D light;
    void Awake()
    {
        light = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
        player.eatenCandy += startbrighten;
    }
    
    void startbrighten(object sender, EventArgs e)
    {
        StartCoroutine(brighten());
    }
    IEnumerator brighten()
    {
        Debug.Log($"Eat candy! {InventoryScript.numOfCandies} candy left.");
        candySound.PlayOneShot(clip, volume);
        
        light.pointLightInnerRadius = 6;
        light.pointLightOuterRadius = 10;
        yield return new WaitForSeconds(7);
        light.pointLightInnerRadius = 1;
        light.pointLightOuterRadius = 4;
    }
    // Update is called once per frame
    void Update()
    {
        
        transform.position = playerPos.position;
    }

}
