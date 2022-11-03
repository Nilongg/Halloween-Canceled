using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    
    public static int lives = 3;

    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    
        
    

    // Update is called once per frame
    void Update()
    {
        GameManager.instance.livesText.text = "lives left: " + lives;


        if (lives <= 0)
        {
            GameManager.instance.finalText.text = "YOU FAILED TO CANCEL HALLOWEEN :/";


        }
    }
}
