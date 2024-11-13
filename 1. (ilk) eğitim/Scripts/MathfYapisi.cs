using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfYapisi : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        // movement kodu ...
        float xPozisyon = Mathf.Clamp(transform.position.x, -4.81f, 4.19f);
        transform.position = new Vector2(xPozisyon, transform.position.y);
        // bu kodun amacı şu: x pozisyonunda-4.81 ile 4.19 pozisyonlarının dışına çıkılamaz. yani pozisyonu kısıtlıyor, kelepçeliyoruz (?)
        
        // Mathf.Abs(), içine aldığı değerin mutlak değerini alır.
        // Mathf.Floor(), içine aldığı değer küsüratlıysa mesela 3.49 bunun aşağı yuvarlar 3 olur.
        // Mathf.Cell(), içine aldığı değer küsüratlıysa onu yukarı yuvarlar 3.49i 4 yapar.
        // Mathf.Round(), içine aldığı değeri küsüratlıysa yuvarlar.
    }
}
