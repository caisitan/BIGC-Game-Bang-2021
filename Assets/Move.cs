using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed;
	public float jump;
	public GameObject rayOrigin;
	public float rayCheckDistance;
	Rigidbody2D rb;

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}
		
	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis("Vertical");
        Vector3 rotationVector = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);
        transform.rotation = rotation;
        rb.velocity = new Vector3 (x * speed, y*speed, 0);

	}
}