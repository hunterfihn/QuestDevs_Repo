using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS IS A CHANGE TO OBSERVE GITHUB PUSHING

public class MovingBoxes : MonoBehaviour
{
    public Vector3 goUp, goForward, goBack, goLeft, goRight;
    public float speed = 200.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() // Like a constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.back * speed;
    }
}