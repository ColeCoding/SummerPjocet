using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] float jumpForce;
    private int playerDirection;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        playerDirection = 0;
    }

    // Update is called once per frame
    void Update()
    {
     //This is where we add forces that move the guy
        playerDirection = 0;
        if (Input.GetKey(KeyCode.D))
        {
            playerDirection += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerDirection += -1;
        }


        rigidBody.AddForce(Vector3.right * playerSpeed * playerDirection);
    // Jump force here
    if(Input.GetKeyDown(KeyCode.W))
        {
            rigidBody.AddForce(Vector3.up * jumpForce);
        }
    }
}
