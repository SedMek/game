using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public MoveEnnemy moveEnnemyScript;
    private void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.GetComponent<Rigidbody2D>().tag == "ennemy")
        {
            moveEnnemyScript.Flip();
        }
    }
}
