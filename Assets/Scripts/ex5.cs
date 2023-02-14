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
            sum = sum + number; //sum of the elements of the array  
        }

        Debug.Log($"{numbers[0]} + {numbers[1]} + {numbers[2]} + {numbers[3]} + {numbers[4]} = {sum}"); //condition is checked
    }


}
 