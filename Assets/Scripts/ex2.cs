using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    public string message = "Hola, holita, vecinito";
    public int i = 1;
    private void Start()
    {
        while (i <= 1) //the console prints the message once whith a while loop
        {
            Debug.Log(message); //condition is checked
            i++; //stop condition 
        }
    }
}
