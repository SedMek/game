using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.GetComponent<Collider2D>().tag == "Player")
        {
            animator.enabled = true;
            Invoke("CompleteLevel", 2);
        }
    }

    private void CompleteLevel()
    {
        FindObjectOfType<GameManager>().completeLevel();

    }

}
