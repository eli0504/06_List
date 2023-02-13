using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    public int start = 3;
    public int end = 27;
    private int i = 0;

    private void Start()
    {
        while (i > start)
        {
            if (i % 5 == 0)
            {
                Debug.Log(i);
                i += 5;
            }else if (i < end)
            {
                Debug.Log(i);
                i += 5;
            }
            
        }
    }
}