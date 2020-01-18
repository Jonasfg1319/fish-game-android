using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{
   
    public static int score = 0;
    public Text score_txt,record_txt;
    public static int record = 0,aux = 0;
    // Start is called before the first frame update
    void Start()
    {
        record_txt.text = record.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score_txt.text = score.ToString();
       
        

        
        if(Player.death == true)
        {
            SceneManager.LoadScene("Game Over");
            Player.death = false;
            if (score > aux) {
                aux = score;
               
            }
            score = 0;
        }

    }


}
