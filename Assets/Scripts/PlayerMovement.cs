using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 20f;
    public float sprintSpeed = 40f;

    public Animator animator;
    float horizontalMove = 0f;
    bool jump = false;
    bool sprint = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        // Handling jumping
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        // Handling sprinting
        if (Input.GetButtonDown("Sprint"))
        {
            sprint = true;
            animator.SetBool("IsSprinting", true);
        }
        else if (Input.GetButtonUp("Sprint"))
        {
            sprint = false;
            animator.SetBool("IsSprinting", false);
        }
        // Handling crouching
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            animator.SetBool("IsCrouching", true);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * (sprint ? sprintSpeed : runSpeed);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

    }

    public void OnLanding()
    {
        // Debug.Log("has landed");
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
