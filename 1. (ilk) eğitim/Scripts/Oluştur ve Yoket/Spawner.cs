using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnedCube;
    private void Start()
    {
        float randomPosition = Random.Range(-3, 3); // Bu satýr, objenin x deðeri 3 ile -3 arasýnda rastgele spawn olmasýný saðlayacak.
        var spawnCube = Instantiate(spawnedCube, new Vector3(randomPosition,transform.position.y,transform.position.z), Quaternion.identity); // bu kodun açýklamasý "oyun baþladýðýnda kübü üret, x deðerini rastgele al y ve z deðerleri kalsýn þeklinde üret, rotasyonu objenin kendi rotasyonu olsun" þeklindedir.
        // var, spawn edildikten sonra variable olarak kaydedilmesini saðlar. sonradan uygulanacak iþlemleri kolaylaþtýrmak için.
        Destroy(spawnCube, 3f); // Bu satýr, küp spawn olduktan 3 saniye sonra silinecek anlamýna geliyor.
    }
}
