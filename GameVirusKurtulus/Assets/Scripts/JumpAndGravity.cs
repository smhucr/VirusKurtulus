using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndGravity : MonoBehaviour
{
    public PlayerMovement pmove;
    public CharacterController controller;
    private Vector3 velocity;
    private float gravity = -9.807f;
    public float gravityDivide = 100f;
    public float jumpHeight = 0.1f;
    public float jumpSpeed = 30f;
    private bool isGround;
    public Transform groundChecker;
    public float groundCheckerRadius;
    public LayerMask obstacleLayer;
    
    private void Update()
    {
        isGround = Physics.CheckSphere(groundChecker.position, groundCheckerRadius, obstacleLayer);
        if (!isGround){ 
            velocity.y += gravity * Time.deltaTime /gravityDivide;
            StartCoroutine(AfterJumpWaitOne());

        }
        else
        {
            velocity.y = 0f;
            pmove.speed = 5f;
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity / gravityDivide);
        }
        controller.Move(velocity);  
    }
    IEnumerator AfterJumpWaitOne()
    {
        yield return new WaitForSeconds(1f);
        if (!isGround)
        {
            pmove.speed = jumpSpeed;
            if (isGround)
            { 
                    velocity.y = 0f;
                    pmove.speed = 5f;
            }
        }
    }
 
}
