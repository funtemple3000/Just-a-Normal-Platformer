using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public static int numOfCandies = 0;
    void Start()
    {
        Debug.Log("Reset!");
        numOfCandies = 0;
    }
}
