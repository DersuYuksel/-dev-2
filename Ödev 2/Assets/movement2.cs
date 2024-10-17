using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float hiz = 5f; 
    private Rigidbody2D rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        float yatayHareket = 0f;

        if (Input.GetKey(KeyCode.A)) 
        {
            yatayHareket = -hiz;
        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            yatayHareket = hiz;
        }

        
        rb.velocity = new Vector2(yatayHareket, rb.velocity.y);
    }
}
