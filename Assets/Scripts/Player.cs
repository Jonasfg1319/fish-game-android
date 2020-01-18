using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 120f;
    Rigidbody2D rb;
    public static  bool death = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {

       

    }


   public void right() {

        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);

    }

    public void left() {
        rb.velocity = new Vector2(-speed * Time.fixedDeltaTime, rb.velocity.y);
    }

    public void up() {
        rb.velocity = new Vector2(rb.velocity.x,Time.fixedDeltaTime * speed);

    }

    public void down() {

        rb.velocity = new Vector2(rb.velocity.x, Time.fixedDeltaTime * -speed);

    }

    public void Stop() {

        rb.velocity = new Vector2(0, 0);
    }

}
