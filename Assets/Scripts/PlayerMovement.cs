using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller; // assign the character controller script to this script

    public float runSpeed = 50f; // amount of speed applied to the player

    float horizontalMove = 0f; 

    bool jump = false; // jump is false by default

     public Animator animator; // assign the animations for the player

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

          animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

          if (Input.GetButtonDown("Jump"))
          {
              jump = true;
              animator.SetBool("PlayerIsJumping", true);
          }

      }

      public void Landing()
      {
          animator.SetBool("PlayerIsJumping", false);

      }

        void FixedUpdate()
        {

            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;

        }
    }
