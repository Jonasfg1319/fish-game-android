using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ini : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Comecar() {

        SceneManager.LoadScene("Game");
        
    }
    public void Sair() {

        Application.Quit();
    }
}
