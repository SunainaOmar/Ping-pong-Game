using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public bool isp1;
    float move;


    // Update is called once per frame
    void Update()
    {
        if (isp1)
        {
            move = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            move = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, move * speed);

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -4.2f, 4.2f));
    }
}
