using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;

//Add this line below the speed variable declaration

    public Rigidbody rb;

    float HorizontalInput;
    public float horizontalMultiplier = 2;
    private void FixedUpdate(){

	Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
    Vector3 HorizontalMove = transform.right * HorizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
	rb.MovePosition(rb.position + forwardMove + HorizontalMove);
}   
    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
    }
}
