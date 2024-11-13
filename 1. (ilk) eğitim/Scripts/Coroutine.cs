using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public float bekleme;
    void Start()
    {
        
    }
    
    //Coroutine ile spawner gibi sistemler yazılabilir. mesela oyun başladığında 3 enemy spawnla 10 saniye sonra 5 enemy spawnla gibi.
    // Time.timeScale = 0.5f; // Eğer bekleme değerimiz 7 ise 14 saniyede çalışacak çünkü oyun hızımız yarıya indi. Bunu önlemek için Realtime eklemeliyiz coroutine'e. Örnek aşağıda. oyunun varsayılan hızı 1'dir.
    // Time.timeScale hakkında bir mekanik fikri: Br platform oyununda sağ tıklayınca 1den 0.5'e düşmesi.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Deneme()); // Coroutine'i böyle çağırıyoruz.
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            StopAllCoroutines(); // sadece bu kodun içindeki coroutineleri durdurur.
        }
    }

    IEnumerator Deneme()
    {
        Debug.Log("asasdsda");
        yield return new WaitForSecondsRealtime(bekleme); // önce ilk debug.log yazılacak sonra "bekleme" saniye sonra ikinci debug.log çalışacak
        Debug.Log("Csaodapds");
    }
}
