using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    // Aktifle�tirmek istedi�in script
    public MonoBehaviour scriptToActivate;

    private void Start()
    {
        // Script'i ba�lang��ta devre d��� yap�yoruz
        if (scriptToActivate != null)
        {
            scriptToActivate.enabled = false;
        }
    }

    // Top zemine �arpt���nda �al��acak fonksiyon
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Zemin ile �arp��may� kontrol et (zemin tag'i "Zemin" olmal�)
        if (collision.gameObject.tag == "Zemin")
        {
            if (scriptToActivate != null)
            {
                scriptToActivate.enabled = true; // Script'i aktif et
            }
        }
    }
}

