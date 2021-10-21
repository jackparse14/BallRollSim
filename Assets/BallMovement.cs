using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    private Rigidbody rb;
    private void Start() {
        rb = GetComponent<Rigidbody>();
    }
    public void MoveUp() {
        rb.AddForce(new Vector3(0f, 0f, movementSpeed));
    }
    public void MoveDown()
    {
        rb.AddForce(new Vector3(0f, 0f, -movementSpeed));
    }
    public void MoveLeft()
    {
        rb.AddForce(new Vector3(-movementSpeed, 0f, 0f));
    }
    public void MoveRight()
    {
        rb.AddForce(new Vector3(movementSpeed, 0f, 0f));
    }
}
