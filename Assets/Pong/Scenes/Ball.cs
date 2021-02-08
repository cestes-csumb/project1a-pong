using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.5f;
    public float impulse = 1.0f;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        //Serve();
        //Debug.Log($"Current Force: {startForce}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Serve();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        if (collision.gameObject.name.Equals("PaddleLeft")) {
            //Debug.Log("Collided with paddle");
            rb.AddForce((transform.right * impulse), ForceMode.Impulse);
        } else if (collision.gameObject.name.Equals("PaddleRight")) {
            rb.AddForce((transform.right *-1.0f * impulse), ForceMode.Impulse);
            //Debug.Log($"Current Velocity: {rb.velocity}");
        }
    }
    private void OnTriggerEnter(Collider other) {
        //Debug.Log("test");
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
    }

    void Serve() { 
        Vector3 startForce = Vector3.forward;
        Rigidbody rb = this.GetComponent<Rigidbody>();
        startForce.z += -20.0f * speed;
        startForce.x += -25.0f * speed;
        rb.useGravity = true;
        rb.AddForce(startForce);
    }
}
