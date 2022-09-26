using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public Vector3 gravity;
    public Vector3 jumpSpeed;

    bool isGrounded =false;
    Rigidbody rb;
    // Start is called before the first frame update
    void Awake() 
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.anyKeyDown && isGrounded)
      {
        rb.velocity=jumpSpeed;
        isGrounded=false;
      }  
    }
    void OnCollisionEnter(Collision collision)
    {
      isGrounded=true;
    }
}
