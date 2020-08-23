using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnnemy : MonoBehaviour
{
    private bool m_FacingRight = true;  // For determining which way the player is currently facing.

    public int movementVelocity = 1;
    public int direction = -1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direction * movementVelocity, rb.velocity.y);
    }


    public void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        // multiply the direction by -1
        direction *= -1;
    }

}
