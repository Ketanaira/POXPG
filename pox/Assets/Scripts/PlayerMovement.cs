using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpForce = 300;
    public Rigidbody2D rigidbody2;
    public SpriteRenderer spriteRenderer;
    public GroundChecker groundChecker;
    public Animator anim;
    public bool isJump = false;
    float moveInput;
    public bool isJumping = false;
    public bool isWalk = false;

    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        groundChecker = GetComponent<GroundChecker>();
        anim = GetComponent<Animator>();


    }


    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space)){ 
        isJump = true;
      

        }

        moveInput = Input.GetAxis("Horizontal");
       if (moveInput != 0) {
            anim.SetBool("isWalk",true);
        } else
            anim.SetBool("isWalk", false);

        if (moveInput < 0)
            GetComponent<SpriteRenderer>().flipX = true;
        else
            GetComponent<SpriteRenderer>().flipX = false;

        if (groundChecker.isGrounded)
            anim.SetBool("isJumping", false);
       else
            anim.SetBool("isJumping", true);
    }

    private void FixedUpdate()
    {
        rigidbody2.velocity = new Vector2(moveInput * moveSpeed * Time.fixedDeltaTime, rigidbody2.velocity.y);
        if (isJump && groundChecker.isGrounded)
        {
            rigidbody2.AddForce(Vector2.up * jumpForce);
        }
        isJump = false;
       
    }
}
