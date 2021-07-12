using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    
    private Rigidbody2D rb;
    private Vector3 MoveVelocity;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        MoveVelocity = moveInput.normalized * speed;
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
