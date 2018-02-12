using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankController : MonoBehaviour {

	//public float speed = 1;
	public float movementSpeed = 10;
	public float turningSpeed = 60;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float horizontal = Input.GetAxis("Horizontal")	* turningSpeed * Time.deltaTime;
		transform.Rotate(0,horizontal, 0);

		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate(0, 0, vertical);

		//Vector3 movement = new Vector3 (Horizontal, 0.0f, Vertical);
        //rb.AddForce (movement * speed);
    }
}
