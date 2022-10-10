
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Candy touched: " + collision.transform.tag);
        if(collision.transform.tag == "Player")
        {
            Debug.Log("Got 1 candy!");
            InventoryScript.numOfCandies++;
            transform.gameObject.SetActive(false);
        }
    }
}
