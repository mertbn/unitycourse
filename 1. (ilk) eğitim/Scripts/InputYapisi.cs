using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputYapisi : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Kodumuzun anlamı "Space tuşuna BASILDIĞI ANDA (bir kere çalışır) konsola cartcurt yaz.Input.GetKeyDown(KeyCode.Space) tuşumuzun Space olduğunu, Space'e basıldığında... anlamına gelir.
        {
            Debug.Log("cartcurt"); // GetKeyUp BASIP ÇEKTİKTEN SONRA çalışır
                                   // GetKey BASILI TUTULDUĞU SÜRECE çalışır
        }

        if (Input.GetMouseButtonDown(0)) // Bu mouse için. yukarıdaki up ve normal kural bunda da geçerli.
        {
            // 0 = Sol Tık 
            // 1 = Sağ Tık
            // 2 = Mouse Tekeri
        }

        if (Input.anyKeyDown)
        {
            // Herhangi bir tuşa basılınca gerçekleşecek olay.
        }
        
        
        /*public float yatayHiz,dikeyHiz; // Hız ayarlayabilmek için yatay ve dikey hız ile Horizontal Vertical değerlerini çarpıyoruz.
        
        float yatayKontrol = Input.GetAxis("Horizontal") * yatayHiz; // Mouse'ı takip etmetsini istersek HorizontalVertical yerine Mouse X ve Y yazabiliriz. .io oyunları için ideal
        float dikeyKontrol = Input.GetAxis("Vertical") * dikeyHiz;
        
        transform.Translate(yatayKontrol * Time.deltaTime, dikeyKontrol * Time.deltaTime, 0f); // Hızı kontrol edebilmek için Time.deltaTime ile çarptık. z'ye bilerek değer vermedim normalde ona da verielbilir */
    }
}
