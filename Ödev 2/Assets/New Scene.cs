using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Sahne2");
        }
        if (collision.CompareTag("Player2"))
        {
            SceneManager.LoadScene("Sahne3");

        }
        if (collision.CompareTag("Player3"))
        {
            SceneManager.LoadScene("SampleScene");

        }

    }
}
