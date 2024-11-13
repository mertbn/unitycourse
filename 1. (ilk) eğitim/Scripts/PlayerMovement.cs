using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //Vector3 bi�iminde bir de�er olu�turduk ve yeni bir vector3 ile her saniye tu�lara bas���m�z olacak. Horizontal = X de�eri - Vertical = Z de�eri
        transform.position = transform.position + moveDirection * moveSpeed * Time.deltaTime;
    }
}
