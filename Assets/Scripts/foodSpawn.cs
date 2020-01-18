using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodSpawn : MonoBehaviour
{
    public GameObject food;
    float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 4) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed * Time.deltaTime, 0);

        }
        else if(transform.position.x < -9)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed * Time.deltaTime, 0);

        }
    }

    public void spawner() {

        Instantiate(food, transform.position, Quaternion.identity);
    }
}
