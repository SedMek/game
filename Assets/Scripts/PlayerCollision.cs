using System.Collections;
using System.Collections.Generic;
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
        if (collisionInfo.collider.tag == "ennemy")
        {

            Debug.Log(collisionInfo.collider.tag);
            PlayerHurtAnimation();
            movement.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;

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
