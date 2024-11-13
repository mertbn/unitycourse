using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateKomutu : MonoBehaviour
{
    public GameObject nesne;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // bu kod sayesinde space tuşuna basıldığında aynı yerde bir tane daha obje klonlanacak.
            Instantiate(nesne, transform.position, Quaternion.identity);   // GameObject'in klonlarını oluşturmak için kullanılır. Instantiate() içerisinde 3 bölüm vardır. Birincisi oluşturulacak nesne (GameObject), ikincisi oluşacak nesnenin hangi pozisyonlarda oluşacağı, üçüncüsü açıları nasıl olacak. Quaternion.identity = objenin açılarının 0 0 0 olması. transform.position = kodu hangi objeye atarsak o objenin pozisyonu olacak. Eğer pozisyonu değiştirmek istersen new Vector3 yazmamız lazımdı.
        }
    }
}
