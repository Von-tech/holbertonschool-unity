using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F; 
    private bool canJump = true;
    private Rigidbody selfRigidbody;
    public float sensitivity = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        // isOnGround = true;
        selfRigidbody = GetComponent<Rigidbody>();
        if (selfRigidbody == null)
        {
            selfRigidbody = gameObject.AddComponent<Rigidbody>();
        }
    }

    void Update()
    {
        float horizontal = 0, vertical = 0;

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            selfRigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            canJump = false;
        }

		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            vertical = 1;

		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            vertical = -1;

		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            horizontal = -1;

		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            horizontal = 1;

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction = Quaternion.Euler(0, transform.eulerAngles.y, 0) * direction;

        transform.position += direction * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
}
