using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interaction;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        var hiz = rb.velocity;
        hiz.x = (Input.GetAxis("Horizontal") * speed);
        hiz.y = (Input.GetAxis("Vertical") * speed);
        rb.velocity = hiz;

    }
}


