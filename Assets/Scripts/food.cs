using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")){
            GameMan.score += 1;
            Destroy(this.gameObject);

        } else if (other.gameObject.CompareTag("BottomB"))
        {
            Destroy(this.gameObject);
        }

    }
}
