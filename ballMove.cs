using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballMove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    public float p1Score;
    public float p2Score;

    public Text p1text;
    public Text p2text;

    public Vector2 startPos;
    //public Vector2 EndPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Launch();
        //endPos = transform.position;
    }

    private void Update()
    {
        p1text.text = p1Score.ToString();
        p2text.text = p2Score.ToString();
    }
    
    public void Launch()
    {
        float x = Random.Range(0, 2) == 0? -1: 1;
        float y = Random.Range(0, 2) == 0? -1: 1;

        rb.velocity = new Vector2(x * speed, y * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "p1goal")
        {
            p1Score++;
            rb.velocity = Vector2.zero;
            transform.position = startPos;
            Launch();
            //transform.position = endPos;
        }

        if (collision.gameObject.tag == "p2goal")
        {
            p2Score++;
            rb.velocity = Vector2.zero;
            transform.position = startPos;
            Launch();
            //transform.position = endPos;
        }
    }    
}
