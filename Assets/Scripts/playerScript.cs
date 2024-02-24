using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    private float xLimit = 24f;
    private float zLimit = 12f;

    private float speed = 8f;

    private Vector3 prevPos;

    private bool collisionFlag = false;
    // Update is called once per frame
    void FixedUpdate()
    {

        fixCollision();
        Move();
        //ABSTRACTION
    }

    private void OnTriggerEnter(Collider other)
    {
        collisionFlag = true;
    }
    private void OnTriggerExit(Collider other)
    {
        collisionFlag = false;
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        if (transform.position.x > xLimit | transform.position.x < -xLimit)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zLimit | transform.position.z < -zLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z * -1);
        }
    }

    private void fixCollision()
    {
        if (collisionFlag)
        {
            transform.position = prevPos;
        }
        else
        {
            prevPos = transform.position;
        }
    }
}
