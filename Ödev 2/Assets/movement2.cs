using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float hiz = 5f; // Topun saða ve sola hareket hýzý
    private Rigidbody2D rb;

    void Start()
    {
        // Rigidbody2D bileþenini al
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // A ve D tuþlarýna göre yatay eksende hareket
        float yatayHareket = 0f;

        if (Input.GetKey(KeyCode.A)) // A tuþuna basýlýrsa sola git
        {
            yatayHareket = -hiz;
        }
        else if (Input.GetKey(KeyCode.D)) // D tuþuna basýlýrsa saða git
        {
            yatayHareket = hiz;
        }

        // Topu hareket ettir (x ekseninde)
        rb.velocity = new Vector2(yatayHareket, rb.velocity.y);
    }
}
