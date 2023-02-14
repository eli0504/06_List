using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    public int start = 3;
    public int end = 27;
    private int i;

    private void Start()
    {
        i = start;
        while (i < end)
        {
            if (i % 5 == 0)
            {
                Debug.Log(i);
            }

            i++;
        }
    }
}
 