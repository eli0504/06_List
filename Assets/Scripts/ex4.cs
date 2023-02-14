using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    //left end of the interval and the right end
    public int start = 3;
    public int end = 27;
    public int i;

    private void Start()
    {
        //while loop that displays all multiples of 5 between start and end

        i = start; //i = 3
        while (i < end) //i is less than 27
        {
            if (i % 5 == 0) //body calculating the multiples
            {
                Debug.Log(i); //condition is checked
            }

            i++;  //stop condition
        }
    }
}
 