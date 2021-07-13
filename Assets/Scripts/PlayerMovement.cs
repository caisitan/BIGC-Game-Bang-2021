using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    
    private Rigidbody2D rb;
    private Vector3 MoveVelocity;
    private Animator animator;
    private bool jump;
    private bool jumped = true;
    private int JumpCounter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        jump = Input.GetKeyDown(KeyCode.Space);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        MoveVelocity = moveInput.normalized * speed;
        jump = Input.GetKeyDown(KeyCode.Space);
        if (!jumped && jump && JumpCounter <= 1)
        {
            rb.gravityScale = 0;
            rb.AddForce(new Vector2(0, 1 * 120));
            animator.SetInteger("isJump", 1);
            JumpCounter++;
            rb.gravityScale = 1;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumped = false;
        JumpCounter = 0;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
    private void FixedUpdate()
    {
        if (MoveVelocity != Vector3.zero)
        {
            rb.AddForce(MoveVelocity);
            animator.SetInteger("isWalk", 1);
        }
        else
        {
            animator.SetInteger("isWalk", 0);
        }
        
    }
}
