using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public MonoBehaviour scriptToActivate;

    private void Start()
    {
        if (scriptToActivate != null)
        {
            scriptToActivate.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zemin")
        {
            if (scriptToActivate != null)
            {
                scriptToActivate.enabled = true; 
            }
        }
    }
}

