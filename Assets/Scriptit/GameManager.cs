using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public int placedPumpkins;

    public TextMeshProUGUI pumpkingText;
    public TextMeshProUGUI finalText;
    public TextMeshProUGUI livesText;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        pumpkingText.text = "Pumpkins placed: " + placedPumpkins;
        if(placedPumpkins == 5)
        {
            pumpkingText.text = "";
            finalText.text = "Congratulations, you collected all the pumpkins, now halloween shall be canceled.";
            StartCoroutine(TheEnd());
        }

    }
    IEnumerator TheEnd()
    {
        yield return new WaitForSeconds(3);
        finalText.color = Color.red;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("jumppuscare");
        finalText.text = "Did you really think, that you could cancel halloween, hah!";



    }
}
