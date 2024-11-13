using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materyal : MonoBehaviour
{
    public Color colorChange;
    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Renderer>().material.color = colorChange;
    }
}
