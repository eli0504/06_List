using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    public int[] numbers;
    private int sum = 0;

    private void Start()
    {
        foreach(int number in numbers)
        {
            sum += number;
        }

        Debug.Log(sum);

    }
}
