using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F; 
    // public float gravity = 20.0F;
    // private Vector3 moveDirection = Vector3.zero;
    private bool canJump = true;
    private Rigidbody selfRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // isOnGround = true;
        selfRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            selfRigidbody.AddForce(0, jumpSpeed, 0, ForceMode.Impulse);
        }

		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
			transform.position += Vector3.left* speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
			transform.position += Vector3.back* speed * Time.deltaTime;
		}
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
}
