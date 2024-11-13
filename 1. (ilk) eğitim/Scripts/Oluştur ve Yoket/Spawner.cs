using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnedCube;
    private void Start()
    {
        float randomPosition = Random.Range(-3, 3); // Bu sat�r, objenin x de�eri 3 ile -3 aras�nda rastgele spawn olmas�n� sa�layacak.
        var spawnCube = Instantiate(spawnedCube, new Vector3(randomPosition,transform.position.y,transform.position.z), Quaternion.identity); // bu kodun a��klamas� "oyun ba�lad���nda k�b� �ret, x de�erini rastgele al y ve z de�erleri kals�n �eklinde �ret, rotasyonu objenin kendi rotasyonu olsun" �eklindedir.
        // var, spawn edildikten sonra variable olarak kaydedilmesini sa�lar. sonradan uygulanacak i�lemleri kolayla�t�rmak i�in.
        Destroy(spawnCube, 3f); // Bu sat�r, k�p spawn olduktan 3 saniye sonra silinecek anlam�na geliyor.
    }
}
