using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy;
    float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 3.50)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed * Time.deltaTime);

        }
        else if (transform.position.y < -4.50)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,speed * Time.deltaTime);

        }
    }

    public void spawner()
    {

        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
