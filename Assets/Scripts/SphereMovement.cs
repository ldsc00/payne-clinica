using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float force
    private float xInput, zInput;
    private RigidBody playerRb;

    void Start()
    {
        playerRb = GetComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
       xInput = Input.GetAxisRaw("Horizontal");
       zInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(xInput, 0f, zInput);
        playerRb.AddForce(input * force);
    }

}
