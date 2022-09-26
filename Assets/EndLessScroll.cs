using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class EndLessScroll : MonoBehaviour
{
    public float scrollFactor = -1;
    public Vector3 gameVelocity;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameVelocity*scrollFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider GameArea)
    {
        transform.position += Vector3.right *(GameArea.bounds.size.x+GetComponent<BoxCollider>().size.x); 
    }

    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
