using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    private void Start()
    {
        // for loop to print the even numbers from 0 to 100 in descending order
        for (int i = 100; i >= 0; i-=2)
        {
            Debug.Log(i); //condition is checked
        }
    }
}
