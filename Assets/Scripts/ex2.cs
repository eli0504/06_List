using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    private string i = "Hola, holita, vecinito";
    private void Start()
    {
        while (i<=20)
        {
            Debug.Log(i);
            i++;
        }
    }
}
