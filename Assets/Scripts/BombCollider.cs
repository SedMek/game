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
            // if the player hit the bottom of the bomb, he's hurt
            if (collisionInfo.otherCollider is CircleCollider2D)
            {

                animator.SetBool("IsExploded", true);
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                Invoke("Remove", 0.3f);
            }
            // else if the player hit the top of the bomb, hecan jump over it
            else if (collisionInfo.otherCollider is EdgeCollider2D)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                Invoke("Remove", 0.3f);
            }

        }
    }

    void Remove()
    {
        Destroy(this.gameObject);
    }

}
