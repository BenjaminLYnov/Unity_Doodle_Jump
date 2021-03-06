using UnityEngine;

public class Move : MonoBehaviour
{
    public float forceMove = 4.0f;
    public float forceJump = 4.0f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveLateral();

        if (rb.velocity.y > 50)
            rb.velocity = new Vector2(rb.velocity.x, 50);
        else if (rb.velocity.y < -10)
            rb.velocity = new Vector2(rb.velocity.x, -10);
    }

    void MoveLateral()
    {
        Vector2 v = rb.velocity;
        v.x = Input.GetAxis("Horizontal") * forceMove;
        rb.velocity = v;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Plateform"))
            rb.AddForce(new Vector2(0, forceJump));
    }


}
