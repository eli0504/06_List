using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    private string message = "Hola, holita, vecinito";
    private int i = 1;
    private void Start()
    {
        while (i <= 1)
        {
            Debug.Log(message);
            i++;
        }
    }
}
