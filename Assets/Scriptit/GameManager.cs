using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public int placedPumpkins;

    public TextMeshProUGUI pumpkingText;
    

    void Awake()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        pumpkingText.text = "Pumpkins placed: " + placedPumpkins;
    }
}
