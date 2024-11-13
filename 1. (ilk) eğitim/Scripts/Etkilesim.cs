using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etkilesim : MonoBehaviour
{
    // Aþaðýdakilerin aynýlarýnýn Collisionlý olanlarý da var. OnCollisionEnter gibi.
    private void OnTriggerEnter(Collider other) // other dediðimiz þey diðer çarptýðý obje.
    {
        // Enter, girildiðinde gerçekleþir.
        if (other.gameObject.CompareTag("Player")) // bu satýrýn anlamý "çarptýðý diðer oyun objesinin tagi "Player" ise...
        {
            // Destroy(gameObject);  genel olarak bu kodun anlamý "Player tagýna sahip obje; diðer objeye (kodu eklediðimiz objeye) çarptýðýnda, o objeyi yok et."
            other.GetComponent<Renderer>().material.color = Color.red; // bu kodun anlamý "player tagýna sahip obje, diðer objeye çarptýðýnda rengini kýrmýzýya çevirsin (karakterin)." eðer other ifadesini çýkartsaydýk diðer objenin rengi deðiþirdi.
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Stay, içindeyken gerçekleþir.
    }

    private void OnTriggerExit(Collider other)
    {
        // Exit, çýkýldýðýnda gerçekleþir.
    }
}
