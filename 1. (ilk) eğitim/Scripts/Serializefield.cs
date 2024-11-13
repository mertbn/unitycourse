using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serializefield : MonoBehaviour
{

    public float saglik = 100;

    [SerializeField] private float para = 100;
    
    // private kullanırsak unity'de göremeyiz. serializefield kullanırsak private'ı unityde görebiliriz. Neden public yazmak yerine serializefield private kullanıyoruz? Sebebi şu: public'ler güvenli değildir. oyunun hacklenmesi gibi bir durumda yukarıdaki saglik'i değiştirebilirler ama para private olduğu için değiştiremezler. Hile yapılmasını, dışardan ulaşılması, üzerinde değişiklik yapılması zor olur. private gizli public halka açık. serializefield'da unity üzerinde private kodu sanki bir publicmiş gibi kullanmamıza olanak sağlar.
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
