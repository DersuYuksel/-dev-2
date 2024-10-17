using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float hiz = 5f; // Topun sa�a ve sola hareket h�z�
    private Rigidbody2D rb;

    void Start()
    {
        // Rigidbody2D bile�enini al
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // A ve D tu�lar�na g�re yatay eksende hareket
        float yatayHareket = 0f;

        if (Input.GetKey(KeyCode.A)) // A tu�una bas�l�rsa sola git
        {
            yatayHareket = -hiz;
        }
        else if (Input.GetKey(KeyCode.D)) // D tu�una bas�l�rsa sa�a git
        {
            yatayHareket = hiz;
        }

        // Topu hareket ettir (x ekseninde)
        rb.velocity = new Vector2(yatayHareket, rb.velocity.y);
    }
}
