using UnityEngine;

public class Movement : MonoBehaviour
{
    public float ziplaGucu = 7f; 
    private Rigidbody2D rb;
    private bool yerdemi = true; 

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.W) && yerdemi)
        {
            rb.velocity = new Vector2(rb.velocity.x, ziplaGucu); 
            yerdemi = false; 
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            yerdemi = true; 
        }
    }
}
