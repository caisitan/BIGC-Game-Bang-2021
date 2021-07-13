using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameStats stats;

    private Rigidbody2D rb;
    private Vector3 MoveVelocity;
    private Animator animator;
    private bool jump;
    private bool jumped = true;
    private int JumpCounter = 0;
    private void Awake()
    {
        stats = GameObject.Find("Game Stats").GetComponent<GameStats>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        jump = Input.GetKeyDown(KeyCode.Space);
        if (GetComponent<SpriteRenderer>().sprite.name == "character(Walk with fire)3")
        {
            animator.SetInteger("isFire", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        MoveVelocity = moveInput.normalized * speed;
        jump = Input.GetKeyDown(KeyCode.Space);
        if (!jumped && jump && JumpCounter <= 1)
        {
            if (stats.bird)
            {
                //rb.gravityScale = 0;
                rb.AddForce(new Vector2(0, 120));
                animator.SetInteger("isWalk", 0);
                animator.SetInteger("isJump", 1);
                JumpCounter++;
                //rb.gravityScale = 1;
            }
            else
            {
                //rb.gravityScale = 0;
                rb.AddForce(new Vector2(0, 120));
                animator.SetInteger("isWalk", 0);
                animator.SetInteger("isJump", 1);
                JumpCounter = 2;
                //rb.gravityScale = 1;
            }
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumped = false;
        JumpCounter = 0;
        animator.SetInteger("isJump", 0);
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
