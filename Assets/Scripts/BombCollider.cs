using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollider : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;


    private void Start()
    {
        animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody2D>();

    }

    void OnBecameInvisible()
    {
        // Debug.Log("on became invisible");
        Destroy(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "ground")
        {
            Destroy(this.gameObject);
        }
        else if (collisionInfo.collider.tag == "Player")
        {
            animator.SetBool("IsExploded", true);
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
