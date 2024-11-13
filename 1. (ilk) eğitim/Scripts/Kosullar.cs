using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kosullar : MonoBehaviour
{
    public GameObject maleCube;
    public GameObject femaleCube;

    public bool isMale;
    private void Start()
    {
        if(isMale == true)
        {
            Instantiate(maleCube, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(femaleCube, transform.position, Quaternion.identity);
        }
    }
}
