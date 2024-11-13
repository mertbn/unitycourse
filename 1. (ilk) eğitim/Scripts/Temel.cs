using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Update = Unity.VisualScripting.Update;

public class Temel : MonoBehaviour
{
    // Start oyun başladığında bir kere çalışır.
    // Update her frame'de bir kere çalışır.

    // Yorum satırı

    /*
     Bu, içinde bulunanları yorum satırına alır
    */

    /*
      float - ondalıklı sayılar
      integer - tam sayılar
      string - yazılar
      vector - xyz yönleri
    */

    /* 
      yazılan değerleri unity'nin görebilmesi için iki seçeneğimiz var:
      private ve public.
      private = default olarak (yani birşey yazmasak ta) bulunur. başka kodlar buna ulaşamaz.
      public = unity ve diğer kodlar da ulaşabilir, görebilir, okuyabilir, yazabilir.
    */
    

    public float number = 5;
    public float number1 = 5.12f; // ondalıklı girilirse sonuna f yazılmalı

    void Start()
    {
        
    }

    
    void Update()
    {
        print(transform.position); // vector örneği. yazdırmak istediğimiz şey her frame'de objenin bulunduğu pozisyon. buna ulaşmak için transformun içindeki position değerini bulmamız lazım. ona da transform.position diyerek ulaşıyoruz.
    }
}
