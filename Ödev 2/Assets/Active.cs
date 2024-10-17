using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    // Aktifleþtirmek istediðin script
    public MonoBehaviour scriptToActivate;

    private void Start()
    {
        // Script'i baþlangýçta devre dýþý yapýyoruz
        if (scriptToActivate != null)
        {
            scriptToActivate.enabled = false;
        }
    }

    // Top zemine çarptýðýnda çalýþacak fonksiyon
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Zemin ile çarpýþmayý kontrol et (zemin tag'i "Zemin" olmalý)
        if (collision.gameObject.tag == "Zemin")
        {
            if (scriptToActivate != null)
            {
                scriptToActivate.enabled = true; // Script'i aktif et
            }
        }
    }
}

