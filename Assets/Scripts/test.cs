using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int start = 3;
    public int end = 27;
    private int i = 0;

    private void Start()
    {
        while(start < end)
        {
            if (i % 7 == 0)
            {
                Debug.Log(i);
                i+=5;
               
            }
            i++;
        }
    }
}
