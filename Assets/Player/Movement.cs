using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour
{
    private Vector2 inputValue = new Vector2();
    private Rigidbody2D bhRigidBody;
    public float maxSpeed = 1f;

    void Start()
    {
        bhRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
        inputValue.y = CrossPlatformInputManager.GetAxis("Vertical");
        bhRigidBody.AddForce(inputValue * bhRigidBody.mass) ;
        bhRigidBody.velocity = Vector2.ClampMagnitude(bhRigidBody.velocity, maxSpeed);
        //print(inputValue.ToString());
        //print(bhRigidBody.velocity.ToString());
    }

}
