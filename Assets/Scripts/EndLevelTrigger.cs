using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log(collisionInfo.collider.tag);
            animator.enabled = true;
        }
    }
}
