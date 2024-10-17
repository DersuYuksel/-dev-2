using UnityEngine;

public class Movement : MonoBehaviour
{
    public float ziplaGucu = 7f; // Z�plama g�c�
    private Rigidbody2D rb;
    private bool yerdemi = true; // Topun yerde olup olmad���n� kontrol etmek i�in

    void Start()
    {
        // Rigidbody2D bile�enini al
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Z�plama - E�er yukar� ok tu�una bas�ld�ysa ve top yerdeyse
        if (Input.GetKey(KeyCode.W) && yerdemi)
        {
            rb.velocity = new Vector2(rb.velocity.x, ziplaGucu); // Y ekseninde z�plama
            yerdemi = false; // Top art�k havada
        }
    }

    // Topun yere de�ip de�medi�ini kontrol etmek i�in
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            yerdemi = true; // Top yere de�di�inde z�plama tekrar aktif olur
        }
    }
}
