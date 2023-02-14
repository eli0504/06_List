using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    public int[] numbers; //array of numbers
    private int sum;

    private void Start()
    {
        foreach(int number in numbers) //foreach loop
        {
            sum += number; //sum of the elements of the array
            Debug.Log(sum); //condition is checked
        }
    }
}
 