using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = 190f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.Rotate(0, 170, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, 0);
        
        
    }


    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("RightB"))
            Destroy(this.gameObject);

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Player.death = true;
        }
    } 


}
