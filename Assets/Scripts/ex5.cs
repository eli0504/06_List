using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    public int[] numbers;
    private int sum;

    private void Start()
    {
        foreach(int number in numbers)
        {
            sum += number;
        }

        Debug.Log($"1 + 2 + 3 + 4 + 5 = {sum}");
    }
}
