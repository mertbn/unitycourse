using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumYapisi : MonoBehaviour
{
    public enum renkSecimi
    {
        Mavi,
        Yesil,
        Kirmizi
    };

    public renkSecimi renk;

    public Color maviRenk, yesilRenk, kirmiziRenk;
    // Enum kendi türlerimizi oluşturmamızı ve kullanmamızı sağlar. tür derke integer v.s. gibi.
    void Start()
    {
        RenkVer();
    }

    private void RenkVer()
    {
        switch (renk)
        {
            // enum ile oluşturduğumuz mavi yeşil kırmızı türlerinin ne işe yarayacağına karar vermek için fonksiyon oluşturduk switch case'ten yardım alarak mavi seçildiyse maviyye boya ... diye gidiyo. 
            case renkSecimi.Mavi:
                GetComponent<SpriteRenderer>().color = maviRenk;
                break;
            case renkSecimi.Yesil:
                GetComponent<SpriteRenderer>().color = yesilRenk;
                break;
            case renkSecimi.Kirmizi: 
                GetComponent<SpriteRenderer>().color = kirmiziRenk;
                break;
        }
    }
}
