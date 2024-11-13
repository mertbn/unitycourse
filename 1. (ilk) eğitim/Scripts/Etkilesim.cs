using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etkilesim : MonoBehaviour
{
    // A�a��dakilerin ayn�lar�n�n Collisionl� olanlar� da var. OnCollisionEnter gibi.
    private void OnTriggerEnter(Collider other) // other dedi�imiz �ey di�er �arpt��� obje.
    {
        // Enter, girildi�inde ger�ekle�ir.
        if (other.gameObject.CompareTag("Player")) // bu sat�r�n anlam� "�arpt��� di�er oyun objesinin tagi "Player" ise...
        {
            // Destroy(gameObject);  genel olarak bu kodun anlam� "Player tag�na sahip obje; di�er objeye (kodu ekledi�imiz objeye) �arpt���nda, o objeyi yok et."
            other.GetComponent<Renderer>().material.color = Color.red; // bu kodun anlam� "player tag�na sahip obje, di�er objeye �arpt���nda rengini k�rm�z�ya �evirsin (karakterin)." e�er other ifadesini ��kartsayd�k di�er objenin rengi de�i�irdi.
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Stay, i�indeyken ger�ekle�ir.
    }

    private void OnTriggerExit(Collider other)
    {
        // Exit, ��k�ld���nda ger�ekle�ir.
    }
}
