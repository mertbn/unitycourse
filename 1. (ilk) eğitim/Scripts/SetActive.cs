using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject nesne1, nesne2;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            nesne1.SetActive(false); // Kodun anlamı "Sol tıka basıldığında nesne1 pasif olsun.
        }
        else if (Input.GetMouseButtonDown(1))

        {
            nesne1.SetActive(true); // Sağ tıklayınca aktif olacak.
        }
    }
}
