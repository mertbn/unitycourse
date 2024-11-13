using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DongulerIleSpawner : MonoBehaviour
{
    public GameObject spawnedCube;
    public int spawnCount;

    private void Start()
    {
        for (int i = 0; i < spawnCount; i++) // spawncounttan az ise -örnek olarak spawncounta 3 diyelim- 3 kere aşağıdaki fonksiyonu oluşturacak.
        {
            Vector3 randomPosition = new Vector3(Random.Range(-3, 3), 1.15f, Random.Range(-2, -11));
            Instantiate(spawnedCube, randomPosition, Quaternion.identity);
        }
    }
}
