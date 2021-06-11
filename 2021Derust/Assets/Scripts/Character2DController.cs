using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour
{
    [SerializeField] float MovementSpeed = 1;
    [SerializeField] float jumpForce = 1;
    private Rigidbody2D rigidbody;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rigidbody.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
            
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ground")
        {
            isGrounded = true;
        }
    }

    private void JumpInput()
    {

    }

    private void GroundDetection()
    {

    }

}