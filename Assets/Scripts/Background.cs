using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Renderer quad;
    // Start is called before the first frame update
    void Start()
    {
        quad = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        quad.material.mainTextureOffset += new Vector2(0.1f * Time.deltaTime, 0);
    }
}
