using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    
    private Rigidbody2D rb;
    private Vector2 MoveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveVelocity = moveInput.normalized * speed;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveVelocity * Time.fixedDeltaTime);
        if (MoveVelocity != Vector2.zero)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, MoveVelocity);
        }
    }
}
