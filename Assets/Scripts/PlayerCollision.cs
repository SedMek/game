using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    private Rigidbody2D rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void PlayerHurtAnimation()
    {
        animator.SetBool("IsHurt", true);
        animator.SetBool("IsJumping", false);
        animator.SetBool("IsCrouching", false);
        animator.SetFloat("Speed", 0);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // Debug.Log(collisionInfo.collider.GetShapeHash() == 3237399407);
        if (collisionInfo.collider.tag == "ennemy" && !(collisionInfo.collider is EdgeCollider2D))
        {

            // Debug.Log(collisionInfo.collider.tag);
            PlayerHurtAnimation();
            movement.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
            rb.gravityScale = 0.5f;
            FindObjectOfType<GameManager>().endGame();
        }
    }

    void OnBecameInvisible()
    {
        movement.enabled = false;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        PlayerHurtAnimation();
        FindObjectOfType<GameManager>().endGame();
    }
}
