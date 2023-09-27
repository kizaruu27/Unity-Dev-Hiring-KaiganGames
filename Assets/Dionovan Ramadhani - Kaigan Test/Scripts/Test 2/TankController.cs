using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float tankSpeed = 5f;
    public Vector3 velocity;
  
    void Update()
    {
        Vector3 movementDirection = new Vector3(-1f, 0, 0);
        velocity = movementDirection * tankSpeed;
        rb.velocity = velocity;
    }
}
