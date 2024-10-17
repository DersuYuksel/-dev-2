using UnityEngine;

public class Movement : MonoBehaviour
{
    public float ziplaGucu = 7f; // Zýplama gücü
    private Rigidbody2D rb;
    private bool yerdemi = true; // Topun yerde olup olmadýðýný kontrol etmek için

    void Start()
    {
        // Rigidbody2D bileþenini al
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Zýplama - Eðer yukarý ok tuþuna basýldýysa ve top yerdeyse
        if (Input.GetKey(KeyCode.W) && yerdemi)
        {
            rb.velocity = new Vector2(rb.velocity.x, ziplaGucu); // Y ekseninde zýplama
            yerdemi = false; // Top artýk havada
        }
    }

    // Topun yere deðip deðmediðini kontrol etmek için
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            yerdemi = true; // Top yere deðdiðinde zýplama tekrar aktif olur
        }
    }
}
